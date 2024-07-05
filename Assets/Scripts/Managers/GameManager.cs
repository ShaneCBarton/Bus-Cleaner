using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameManagerState gameState;
    [SerializeField] private int timeLimit;
    [SerializeField] private GameObject failWindow;

    public string TimeRemaining {get; private set;}

    private int timeRemaining;

    private void Start()
    {
        //timeLimit *= 60;
    }

    private void Update()
    {
        CalculateTime();
        CheckTimer();
    }

    private void CalculateTime()
    {
        timeRemaining = timeLimit - (int)Time.timeSinceLevelLoad;

        string minutes = (timeRemaining / 60).ToString();
        string seconds = (timeRemaining % 60).ToString();

        TimeRemaining = minutes + ":" + seconds;
    }

    private void CheckTimer()
    {
        if (timeRemaining <= 0)
        {
            failWindow.SetActive(true);
            gameState.ChangeState(GameManagerState.State.FAILED);
        }
    }
}
