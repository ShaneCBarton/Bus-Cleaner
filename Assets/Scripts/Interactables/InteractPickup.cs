using UnityEngine;

public class InteractPickup : MonoBehaviour, IInteractable
{
    [SerializeField] PlayerInventory playerInventory;
    [SerializeField] private Objective objectives;
    [SerializeField] private ItemID itemsID;

    public void ExecuteInteraction()
    {
        if (playerInventory.CurrentItem == itemsID)
        {
            objectives.IncrementCompletedObjective();
            Destroy(gameObject);
        }
    }
}
