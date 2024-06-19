using UnityEngine;

public class Garbage : MonoBehaviour, IInteractable
{
    [SerializeField] PlayerInventory playerInventory;
    [SerializeField] private LitterObjectives litterObjectives;

    public void ExecuteInteraction()
    {
        if (playerInventory.CurrentItem == ItemID.TrashBag)
        {
            litterObjectives.IncrementCompletedLitter();
            Destroy(gameObject);
        }
    }
}
