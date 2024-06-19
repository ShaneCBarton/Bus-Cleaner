using UnityEngine;

public class LitterObjectives : MonoBehaviour
{
    [SerializeField] private ObjectiveManager objManager;

    private int numberOfCompletedLitter = 0;

    public void IncrementCompletedLitter()
    {
        numberOfCompletedLitter++;
        CheckIfAllLitterCompleted();
    }

    private void CheckIfAllLitterCompleted()
    {
        if (numberOfCompletedLitter == 4)
        {
            objManager.CompletedObjective();
        }
    }
}
