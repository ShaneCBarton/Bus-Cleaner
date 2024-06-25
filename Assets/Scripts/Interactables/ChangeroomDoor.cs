using UnityEngine;

public class ChangeroomDoor : MonoBehaviour, IInteractable
{
    [SerializeField] private ObjectiveManager objManager;
    [SerializeField] private ScreenFade screenFade;

    private bool completed = false;

    public void ExecuteInteraction()
    {
        if (completed) { return; }

        screenFade.FadeScreen();
        objManager.CompletedObjective();
        completed = true;
    }
}
