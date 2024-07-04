using UnityEngine;

public class RaisePlayerOnBus : MonoBehaviour
{
    [SerializeField] private float heightModifier;

    private CharacterController characterController;

    private void OnTriggerEnter(Collider other)
    {
        characterController = other.GetComponent<CharacterController>();

        if (characterController)
        {
            Vector3 newHeight = new Vector3(0f, heightModifier, 0f);
            characterController.Move(newHeight);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (characterController)
        {
            Vector3 newHeight = new Vector3(0f, -heightModifier, 0f);
            characterController.Move(newHeight);
        }
    }
}
