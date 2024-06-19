using UnityEngine;

public class BusDirt : MonoBehaviour, IInteractable
{
    [SerializeField] private ObjectiveManager objManager;
    [SerializeField] PlayerInventory playerInventory;
    [SerializeField] private DirtObjectives dirtObjectives; 

    public void ExecuteInteraction()
    {
        if (playerInventory.CurrentItem == ItemID.SoapBucket)
        {
            dirtObjectives.IncrementCompletedDirt();
            Destroy(gameObject);
        }
    }
}
