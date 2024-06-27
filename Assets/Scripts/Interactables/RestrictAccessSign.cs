using UnityEngine;

public class RestrictAccessSign : MonoBehaviour, IInteractable
{
    [SerializeField] private BusDoors busDoorsFront;
    [SerializeField] private BusDoors busDoorsRear;
    [SerializeField] private GameObject signUIPopup;
    [SerializeField] private ObjectiveManager objManager;

    public void ExecuteInteraction()
    {
        if (objManager.CompletedObjectives == 6)
        {
            signUIPopup.SetActive(true);
        }
    }
}
