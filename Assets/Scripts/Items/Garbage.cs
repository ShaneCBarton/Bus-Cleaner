using UnityEngine;

public class Garbage : MonoBehaviour, IInteractable
{
    [SerializeField] private ObjectiveManager objManager;

    public void ExecuteInteraction()
    {
        Debug.Log("Picked up garbage");
        objManager.CompletedObjective();
        Destroy(gameObject);
    }
}
