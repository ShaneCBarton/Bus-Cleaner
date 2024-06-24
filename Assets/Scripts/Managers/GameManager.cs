using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameManagerState gameState;
    [SerializeField] private int timeLimit;

    public string TimeRemaining {get; private set;}

    private void Start()
    {
        timeLimit *= 60;
    }

    private void Update()
    {
        CalculateTime();
        CheckTimer();
    }

    private void CalculateTime()
    {
        int time = timeLimit - (int)Time.time;

        string minutes = (time / 60).ToString();
        string seconds = (time % 60).ToString();

        TimeRemaining = minutes + ":" + seconds;
    }

    private void CheckTimer()
    {
        if (timeLimit <= 0)
        {
            gameState.ChangeState(GameManagerState.State.FAILED);
        }
    }
}
