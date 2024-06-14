using UnityEngine;

public class BuildingDoors : MonoBehaviour, IInteractable
{
    [SerializeField] private float rotationAmount;

    private bool doorOpen = false;

    public void ExecuteInteraction()
    {
        if (!doorOpen)
        {
            transform.Rotate(0, rotationAmount, 0);
            doorOpen = true;
        }
        else
        {
            transform.Rotate(0, -rotationAmount, 0);
            doorOpen = false;
        }
    }
}
