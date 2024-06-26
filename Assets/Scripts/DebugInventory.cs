using UnityEngine;

public class DebugInventory : MonoBehaviour
{
    [SerializeField] private PlayerInventory inventory;
    [SerializeField] private GameObject heaterPopup;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            inventory.PickedUpItem(ItemID.SoapBucket);
        }
        else if (Input.GetKeyDown(KeyCode.Y)) 
        {
            inventory.PickedUpItem(ItemID.TrashBag);
        }
        else if (Input.GetKeyDown(KeyCode.U)) 
        {
            inventory.PickedUpItem(ItemID.Vaccuum);
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            inventory.PickedUpItem(ItemID.HotWaterBucket);
        } 
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            heaterPopup.SetActive(true);
        }
    }
}
