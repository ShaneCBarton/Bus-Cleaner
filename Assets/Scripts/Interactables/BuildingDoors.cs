using UnityEngine;

public class BuildingDoors : MonoBehaviour, IInteractable
{
    [SerializeField] private float rotationAmount;
    [SerializeField] private AudioClip doorOpenClip;
    [SerializeField] private AudioClip doorCloseClip;

    private AudioSource audioSource;
    private bool doorOpen = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ExecuteInteraction()
    {
        if (!doorOpen)
        {
            transform.Rotate(0, rotationAmount, 0);
            audioSource.PlayOneShot(doorOpenClip);
            doorOpen = true;
        }
        else
        {
            transform.Rotate(0, -rotationAmount, 0);
            audioSource.PlayOneShot(doorCloseClip);
            doorOpen = false;
        }
    }
}
