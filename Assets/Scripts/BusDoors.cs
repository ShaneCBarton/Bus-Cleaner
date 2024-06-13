
using UnityEngine;

public class BusDoors : Interactable
{
    [SerializeField] private GameObject rightDoorFront;
    [SerializeField] private GameObject leftDoorFront;
    [SerializeField] private GameObject rightDoorBack;
    [SerializeField] private GameObject leftDoorBack;

    [SerializeField] private float rightDoorFrontRotation;
    [SerializeField] private float leftDoorFrontRotation;
    [SerializeField] private float rightDoorBackRotation;
    [SerializeField] private float leftDoorBackRotation;

    private bool doorsOpen = false;
    private Transform rightDoorStart;
    private Transform leftDoorStart;

    private void Start()
    {
        rightDoorStart = rightDoorFront.transform;
        leftDoorStart = leftDoorFront.transform;
    }

    public override void ExecuteInteraction()
    {
        if (!doorsOpen)
        {
            rightDoorFront.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, rightDoorFrontRotation, 0f), 5f);
            leftDoorFront.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, leftDoorFrontRotation, 0f), 5f);
            rightDoorBack.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, rightDoorBackRotation, 0f), 5f);
            leftDoorBack.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, leftDoorBackRotation, 0f), 5f);
            doorsOpen = true;
        } 
        else
        {
            rightDoorFront.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, -28.532f, 0f), 5f);
            leftDoorFront.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, -28.532f, 0f), 5f);
            rightDoorBack.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, -28.532f, 0f), 5f);
            leftDoorBack.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, -28.532f, 0f), 5f);
            doorsOpen = false;
        }

    }
}
