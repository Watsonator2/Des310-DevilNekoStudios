using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startLevelLoader : MonoBehaviour
{
 public void startGame()
    {
        SceneManager.LoadScene("Intro Scene");
    }
}
