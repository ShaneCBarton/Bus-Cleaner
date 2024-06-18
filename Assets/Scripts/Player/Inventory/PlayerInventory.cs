using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private int PPEAmount = 0;
    private ItemID currentItem = 0;

    public bool HasAllPPE
    {
        get
        {
            return PPEAmount == 4;
        }
    }

    public ItemID CurrentItem { get { return currentItem; } }

    public void CollectedPPE()
    {
        PPEAmount++;
    }

    public void PickedUpItem(ItemID newItem)
    {
        currentItem = newItem;
    }
}
