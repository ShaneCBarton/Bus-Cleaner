using UnityEngine;

public class BusHeater : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject heaterUIPopup;
    [SerializeField] private ObjectiveManager objManager;

    public void ExecuteInteraction()
    {
        if (objManager.CompletedObjectives == 5)
        {
            heaterUIPopup.SetActive(true);
        }
    }
}
