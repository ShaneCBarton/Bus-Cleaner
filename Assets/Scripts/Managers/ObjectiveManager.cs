using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    [SerializeField] private int requiredObjectives;
    [SerializeField] private GameManagerState gameState;

    private float completedObjectives;
    private void Update()
    {
        if (completedObjectives == requiredObjectives)
        {
            gameState.ChangeState(GameManagerState.State.COMPLETED);
        }
    }

    public void CompletedObjective()
    {
        completedObjectives++;
    }

}
