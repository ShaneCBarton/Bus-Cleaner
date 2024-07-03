using UnityEngine;

public class EquipItem : MonoBehaviour, IInteractable
{
    [SerializeField] PlayerInventory inventory;
    [SerializeField] GameObject ItemUIIcon;
    [SerializeField] ItemID itemID;

    [SerializeField] private AudioClip itemPickupClip;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ExecuteInteraction()
    {
        inventory.PickedUpItem(itemID);
        audioSource.PlayOneShot(itemPickupClip);
        Transform parent = ItemUIIcon.transform.parent;

        foreach (Transform child in parent)
        { 
            child.gameObject.SetActive(false);
        }

        ItemUIIcon.SetActive(true);
    }
}
