using UnityEngine;

public class GameManagerState : MonoBehaviour
{
    public enum State
    {
        COMPLETED,
        FAILED,
        RUNNING
    }

    private State currentState;

    private void Start()
    {
        currentState = State.RUNNING;
    }

    private void Update()
    {
        switch (currentState)
        {
            case State.COMPLETED:
                // do completion stuff ie. total objectives completed, failed, time taken, bring up menu
                break;

            case State.FAILED:
                // do failed stuff ie. total objectives completed, failed, bring up menu
                //Time.timeScale = 0;
                break;
        }
    }

    public void ChangeState(State state)
    {
        currentState = state;
    }
}
