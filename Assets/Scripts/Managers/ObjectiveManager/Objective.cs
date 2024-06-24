using UnityEngine;

public class Objective : MonoBehaviour
{
    [SerializeField] private ObjectiveManager objManager;
    [SerializeField] private int numberOfRequiredObjectives;

    private int numberOfCompletedObjectives = 0;

    public void IncrementCompletedObjective()
    {
        numberOfCompletedObjectives++;
        CheckIfAllObjectivesCompleted();
    }

    private void CheckIfAllObjectivesCompleted()
    {
        if (numberOfCompletedObjectives == numberOfRequiredObjectives)
        {
            objManager.CompletedObjective();
        }
    }
}
