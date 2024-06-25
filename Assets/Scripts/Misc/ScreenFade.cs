using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScreenFade : MonoBehaviour
{
    [SerializeField] float fadeDuration;

    private Image screenFade;

    private void Start()
    {
        screenFade = GetComponent<Image>();
    }

    public void FadeScreen()
    {
        StartCoroutine(FadeScreenCoroutine(1f));
    }

    private IEnumerator FadeScreenCoroutine(float alphaValue)
    {
        float elapsedTime = 0;
        float startAlpha = screenFade.color.a;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Lerp(startAlpha, alphaValue, elapsedTime / fadeDuration);

            screenFade.color = new Color(screenFade.color.r, screenFade.color.g, screenFade.color.b, alpha);
            
            yield return null;
        }

        yield return new WaitForSeconds(1);
        StartCoroutine(FadeScreenCoroutine(0f));
    }
}
