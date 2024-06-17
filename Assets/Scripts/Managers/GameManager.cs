using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float startingTime;
    [SerializeField] private GameManagerState gameState;

    private float currentTime;


    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= Time.deltaTime;
        CheckTimeOver();
    }

    private void CheckTimeOver()
    {
        if (currentTime < 0f)
        {
            gameState.ChangeState(GameManagerState.State.FAILED);
        }
    }
}
