
using UnityEngine;

public class BusDoors : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject rightDoor;
    [SerializeField] private GameObject leftDoor;

    [SerializeField] private float rightDoorRotation;
    [SerializeField] private float leftDoorRotation;

    [SerializeField] private BoxCollider doorCollider;

    private bool doorsOpen = false;
    private bool busIsSealed = false;

    public void ExecuteInteraction()
    {
        if (!doorsOpen)
        {
            OpenDoors();
        }
    }

    public void CloseBus()
    {
        CloseDoors();
        busIsSealed = true;
    }

    private void OpenDoors()
    {
        if (busIsSealed) { return; }

        rightDoor.transform.Rotate(0, rightDoorRotation, 0);
        leftDoor.transform.Rotate(0, leftDoorRotation, 0);
        doorCollider.enabled = false;
        doorsOpen = true;
    }

    private void CloseDoors()
    {
        if (busIsSealed) { return; }

        rightDoor.transform.Rotate(0, -rightDoorRotation, 0);
        leftDoor.transform.Rotate(0, -leftDoorRotation, 0);
        doorCollider.enabled = true;
        doorsOpen = false;
    }
}
