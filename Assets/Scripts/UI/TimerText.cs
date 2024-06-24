using TMPro;
using UnityEngine;

public class TimerText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private GameManager gameManager;

    private void Update()
    {
        timerText.text = "Time Remaining " + gameManager.TimeRemaining;
    }
}
