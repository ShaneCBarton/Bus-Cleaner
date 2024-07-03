using System.Collections;
using UnityEngine;

public class InteractPickup : MonoBehaviour, IInteractable
{
    [SerializeField] PlayerInventory playerInventory;
    [SerializeField] private Objective objectives;
    [SerializeField] private ItemID itemsID;
    [SerializeField] private AudioClip removedClip;

    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ExecuteInteraction()
    {
        if (playerInventory.CurrentItem == itemsID)
        {
            audioSource.PlayOneShot(removedClip);
            objectives.IncrementCompletedObjective();
            StartCoroutine(DelayDestruction());
        }
    }

    private IEnumerator DelayDestruction()
    {
        yield return new WaitForSeconds(.125f);
        Destroy(gameObject);
    }
}
