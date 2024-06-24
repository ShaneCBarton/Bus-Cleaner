using UnityEngine;

public class ArrowEffects : MonoBehaviour
{
    [SerializeField] private float bounceHeight;
    [SerializeField] private float bounceSpeed;

    [SerializeField] private float pivotAmount;
    [SerializeField] private float pivotSpeed;

    private Vector3 startingPosition;
    private Quaternion startingRotation;

    private void Start()
    {
        startingPosition = transform.position;
        startingRotation = transform.rotation;
    }

    private void Update()
    {
        BounceArrow();
        RotateArrow();
    }

    private void BounceArrow()
    {
        float yPosition = startingPosition.y + bounceHeight * Mathf.Sin(Time.time * bounceSpeed);

        transform.position = new Vector3(startingPosition.x, yPosition, startingPosition.z);
    }

    private void RotateArrow()
    {
        float yRotation = pivotAmount * Mathf.Sin(Time.time * pivotSpeed);

        Quaternion newRotation = Quaternion.Euler(yRotation, 0, 0);
        transform.rotation = startingRotation * newRotation;
    }
}
