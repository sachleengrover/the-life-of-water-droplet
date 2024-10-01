using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnimateText : MonoBehaviour
{
    public TextMeshProUGUI uiText; // Assign your UI Text component in the Inspector
    public string fullText; // The full text to display
    public float delay = 0.1f; // Time delay between each character

    private string currentText = "";
    bool isPlaying = false;

    public void TextShowTrigger()
    {
        if (isPlaying == false)
        {
        StartCoroutine(ShowText());
        }
    }

    IEnumerator ShowText()
    {
        isPlaying = true;
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i + 1);
            uiText.text = currentText;
            yield return new WaitForSeconds(delay); // Wait before adding the next character
        }
        isPlaying = false;
    }
}
