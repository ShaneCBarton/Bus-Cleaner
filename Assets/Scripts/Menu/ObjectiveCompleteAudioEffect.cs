using UnityEngine;

public class ObjectiveCompleteAudioEffect : MonoBehaviour
{
    [SerializeField] private AudioClip clip;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayObjectiveJingle()
    {
        audioSource.PlayOneShot(clip);
    }
}
