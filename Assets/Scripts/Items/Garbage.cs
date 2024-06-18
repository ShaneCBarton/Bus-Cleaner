using UnityEngine;

public class Garbage : MonoBehaviour, IInteractable
{
    [SerializeField] private ObjectiveManager objManager;

    public void ExecuteInteraction()
    {
        objManager.CompletedObjective();
        Destroy(gameObject);
    }
}
