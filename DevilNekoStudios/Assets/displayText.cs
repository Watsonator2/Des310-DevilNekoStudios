using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayText : MonoBehaviour
{
    public GameObject targetText;
    public int timeDisplayed;

    IEnumerator startText()
    {
        targetText.SetActive(true);
        yield return new WaitForSeconds(timeDisplayed);
        targetText.SetActive(false);

    }

   public void showText()
    {
        StartCoroutine(startText());
    }
}
