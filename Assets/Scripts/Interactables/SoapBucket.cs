using UnityEngine;

public class SoapBucket : MonoBehaviour, IInteractable
{
    [SerializeField] PlayerInventory inventory;
    [SerializeField] GameObject bucketInInventory;
    [SerializeField] GameObject itemText;

    public void ExecuteInteraction()
    {
        inventory.PickedUpItem(ItemID.SoapBucket);
        bucketInInventory.SetActive(true);
        itemText.SetActive(false);
    }
}
