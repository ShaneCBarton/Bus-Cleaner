using System.Collections;
using TMPro;
using UnityEngine;

public class TaskTextEffect : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private int maxFontSize;
    [SerializeField] private int minFontSize;
    [SerializeField] private float fontSizingSpeed;
    [SerializeField] private Material fontMaterial;

    private Material baseMaterial;
    private void Start()
    {
        baseMaterial = text.fontMaterial;
    }

    public void PlayTextEffect()
    {
        StartCoroutine(ScaleFontSize());
    }

    private IEnumerator ScaleFontSize()
    {
        while (text.fontSize < maxFontSize)
        {
            text.fontSize += fontSizingSpeed;
            text.fontMaterial = fontMaterial;
            yield return null;
        }

        while (text.fontSize > minFontSize)
        {
            text.fontSize -= fontSizingSpeed;
            yield return null;
        }

        text.fontMaterial = baseMaterial;
    }
}
