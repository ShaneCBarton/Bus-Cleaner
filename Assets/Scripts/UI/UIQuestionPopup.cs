using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIQuestionPopup : MonoBehaviour
{
    [Header("Body Text")]
    [SerializeField] private string questionText;
    [SerializeField] private TextMeshProUGUI questionTMPComponent;

    [Header("Buttons & Text")]
    [SerializeField] private Button answerButtonFirst;
    [SerializeField] private Button answerButtonSecond;
    [SerializeField] private Button answerButtonThird;
    [SerializeField] private TextMeshProUGUI answerTextFirst;
    [SerializeField] private TextMeshProUGUI answerTextSecond;
    [SerializeField] private TextMeshProUGUI answerTextThird;
    [SerializeField] private string buttonTextFirst;
    [SerializeField] private string buttonTextSecond;
    [SerializeField] private string buttonTextThird;

    private void Start()
    {
        questionTMPComponent.text = questionText;
        answerTextFirst.text = buttonTextFirst;
        answerTextSecond.text = buttonTextSecond;
        answerTextThird.text = buttonTextThird;

        answerButtonFirst.onClick.AddListener(FirstButtonClicked);
        answerButtonSecond.onClick.AddListener(SecondButtonClicked);
        answerButtonThird.onClick.AddListener(ThirdButtonClicked);
    }

    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0;
    }

    private void FirstButtonClicked()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

    private void SecondButtonClicked()
    {

    }

    private void ThirdButtonClicked()
    {

    }
}
