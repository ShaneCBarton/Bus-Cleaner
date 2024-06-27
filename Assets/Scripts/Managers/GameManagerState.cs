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
                Debug.Log("You completed your training!");
                break;

            case State.FAILED:
                Debug.Log("You Failed your training!");
                break;
        }
    }

    public void ChangeState(State state)
    {
        currentState = state;
    }
}
