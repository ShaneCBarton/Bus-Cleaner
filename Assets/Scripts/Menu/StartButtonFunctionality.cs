using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonFunctionality : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
}
