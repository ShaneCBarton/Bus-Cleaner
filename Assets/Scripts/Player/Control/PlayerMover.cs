using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float speed = 5.0f;
    [SerializeField] private Transform playerOrientation;

    private CharacterController controller;

    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = playerOrientation.right * x + playerOrientation.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        transform.position = new Vector3(transform.position.x, 1.4f, transform.position.z);
    }
}
