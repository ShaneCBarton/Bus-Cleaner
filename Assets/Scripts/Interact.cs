using UnityEngine;

public class Interact : MonoBehaviour
{
    [SerializeField] private float interactDistance;

    private void Update()
    {
        CheckClick();
    }

    private void CheckClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width * 0.5f, Screen.height * 0.5f));
            
            if(Physics.Raycast(ray, out hit, interactDistance))
            {
                IInteractable interactable = hit.transform.GetComponent<IInteractable>();

                if (interactable != null)
                {
                    interactable.ExecuteInteraction();
                }
            }
        }
    }
}
