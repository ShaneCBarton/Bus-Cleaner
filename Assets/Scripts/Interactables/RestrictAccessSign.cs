using UnityEngine;

public class RestrictAccessSign : MonoBehaviour, IInteractable
{
    [SerializeField] private BusDoors busDoorsFront;
    [SerializeField] private BusDoors busDoorsRear;

    public void ExecuteInteraction()
    {
        busDoorsFront.CloseBus();
        busDoorsRear.CloseBus();
    }
}
