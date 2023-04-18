using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class progressTracker : MonoBehaviour
{

    public bool finalChoice;
    public GameObject progressIndicator;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
      
        Scene currentScene = SceneManager.GetActiveScene();
        
        if(currentScene.name == "VictimsGame")
        {
            progressIndicator.SetActive(true);
        }
    }
}
