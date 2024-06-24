using UnityEngine;

public class BusTrigger : MonoBehaviour
{
    [SerializeField] private float heightModifier;

    private void OnTriggerEnter(Collider other)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y * heightModifier, transform.position.z);
    }

    private void OnTriggerExit(Collider other)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y / heightModifier, transform.position.z);
    }
}
