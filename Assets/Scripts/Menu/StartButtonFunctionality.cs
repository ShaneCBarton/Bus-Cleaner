using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonFunctionality : MonoBehaviour
{
    [SerializeField] private int sceneToLoad;

    public void LoadScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneToLoad);
    }
}
