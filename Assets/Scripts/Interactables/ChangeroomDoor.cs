using UnityEngine;

public class ChangeroomDoor : MonoBehaviour, IInteractable
{
    [SerializeField] private ObjectiveManager objManager;

    private bool completed = false;

    public void ExecuteInteraction()
    {
        if (completed) { return; }

        objManager.CompletedObjective();
        completed = true;
    }
}
