using UnityEngine;

public class BusDirt : MonoBehaviour, IInteractable
{
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
