using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextDialouge : MonoBehaviour
{
    public GameObject firstText;
    public GameObject secondText;

    public void nextIntro()
    {
        if (firstText.activeInHierarchy)
        {
            firstText.SetActive(false);
            secondText.SetActive(true);
        }

        else if (secondText.activeInHierarchy)
        {
            SceneManager.LoadScene("VictimsDesktop");
        }
    }
}
