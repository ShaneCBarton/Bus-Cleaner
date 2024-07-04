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
                EnableMouse();
                break;

            case State.FAILED:
                EnableMouse();
                break;
        }
    }

    public void ChangeState(State state)
    {
        currentState = state;
    }

    private void EnableMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0;
    }
}
