using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    [SerializeField] private int requiredObjectives;
    [SerializeField] private GameManagerState gameState;

    public int CompletedObjectives { get; private set; }

    private void Update()
    {
        if (CompletedObjectives == requiredObjectives)
        {
            gameState.ChangeState(GameManagerState.State.COMPLETED);
        }
    }

    public void CompletedObjective()
    {
        CompletedObjectives++;
    }
}
