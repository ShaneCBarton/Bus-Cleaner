using TMPro;
using UnityEngine;

public class ObjectiveText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI taskText;
    [SerializeField] private ObjectiveManager objManager;

    private void Update()
    {
        taskText.text = "Tasks Completed: " + objManager.CompletedObjectives;
    }
}
