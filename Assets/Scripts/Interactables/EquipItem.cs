using UnityEngine;

public class EquipItem : MonoBehaviour, IInteractable
{
    [SerializeField] PlayerInventory inventory;
    [SerializeField] GameObject ItemUIIcon;
    [SerializeField] ItemID itemID;

    public void ExecuteInteraction()
    {
        inventory.PickedUpItem(itemID);
        Transform parent = ItemUIIcon.transform.parent;

        foreach (Transform child in parent)
        { 
            child.gameObject.SetActive(false);
        }

        ItemUIIcon.SetActive(true);
    }
}
