using System.Collections;
using UnityEngine;

public class OpenNextWindow : MonoBehaviour
{

    [SerializeField] private GameObject nextWindow;

    public void OpenWindow()
    {
        StartCoroutine(WindowOpenDelay());
    }

    private IEnumerator WindowOpenDelay()
    {
        yield return new WaitForSeconds(.25f);
        nextWindow.SetActive(true);
        gameObject.transform.parent.gameObject.SetActive(false);
    }
}
