using UnityEngine;

public class ChangeroomDoor : MonoBehaviour, IInteractable
{
    [SerializeField] private ObjectiveManager objManager;
    [SerializeField] private ScreenFade screenFade;
    [SerializeField] private AudioClip doorOpenClip;

    private AudioSource audioSource;
    private bool completed = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ExecuteInteraction()
    {
        if (completed) { return; }

        screenFade.FadeScreen();
        audioSource.PlayOneShot(doorOpenClip);
        objManager.CompletedObjective();
        completed = true;
    }
}
