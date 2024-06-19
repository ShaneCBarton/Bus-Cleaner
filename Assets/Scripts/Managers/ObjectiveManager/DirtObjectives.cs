using UnityEngine;

public class DirtObjectives : MonoBehaviour
{
    [SerializeField] private ObjectiveManager objManager;

    private int numberOfCompletedDirt = 0;

    public void IncrementCompletedDirt()
    {
        numberOfCompletedDirt++;
        CheckIfAllDirtCompleted();
    }

    private void CheckIfAllDirtCompleted()
    {
        if (numberOfCompletedDirt == 4) 
        {
            objManager.CompletedObjective();
        }
    }
}
