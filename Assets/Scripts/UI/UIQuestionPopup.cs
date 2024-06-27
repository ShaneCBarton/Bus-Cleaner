using TMPro;
using UnityEngine;

public class UIQuestionPopup : MonoBehaviour
{
    [Header("Body Text")]
    [SerializeField] private string questionText;
    [SerializeField] private TextMeshProUGUI questionTMPComponent;

    [Header("Buttons & Text")]
    [SerializeField] private TextMeshProUGUI answerTextFirst;
    [SerializeField] private TextMeshProUGUI answerTextSecond;
    [SerializeField] private TextMeshProUGUI answerTextThird;
    [SerializeField] private string buttonTextFirst;
    [SerializeField] private string buttonTextSecond;
    [SerializeField] private string buttonTextThird;

    [Header("References")]
    [SerializeField] private ObjectiveManager objManager;

    private bool answeredSuccesfully;

    private void Start()
    {
        questionTMPComponent.text = questionText;
        answerTextFirst.text = buttonTextFirst;
        answerTextSecond.text = buttonTextSecond;
        answerTextThird.text = buttonTextThird;
    }

    private void OnEnable()
    {
        if (!answeredSuccesfully)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
        } 
        else
        {
            CloseWindow();
        }
    }

    public void IncorrectButton()
    {
        CloseWindow();
    }

    public void CorrectButton()
    {
        objManager.CompletedObjective();
        answeredSuccesfully = true;
        CloseWindow();
    }


    private void CloseWindow()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
