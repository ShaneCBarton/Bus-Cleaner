using UnityEngine;

public class BusHeater : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject heaterUIPopup;
    [SerializeField] private ObjectiveManager objManager;

    public void ExecuteInteraction()
    {
        if (objManager.CompletedObjectives == 0)
        {
            heaterUIPopup.SetActive(true);
        }
    }
}
