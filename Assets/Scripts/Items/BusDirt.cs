using UnityEngine;

public class BusDirt : MonoBehaviour, IInteractable
{
    [SerializeField] private ObjectiveManager objManager;
    [SerializeField] PlayerInventory playerInventory;

    public void ExecuteInteraction()
    {
        if (playerInventory.CurrentItem == ItemID.SoapBucket)
        {
            Debug.Log("You cleaned the dirt");
            Destroy(gameObject);
        }
    }
}
