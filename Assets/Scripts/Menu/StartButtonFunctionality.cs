using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonFunctionality : MonoBehaviour
{
    [SerializeField] private int sceneToLoad;
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
