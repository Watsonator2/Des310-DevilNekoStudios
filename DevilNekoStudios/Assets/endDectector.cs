using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endDectector : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject progressTracker;
    public GameObject choiceStart;

    // Update is called once per frame
    void Update()
    {
        if (progressTracker.activeInHierarchy){
            choiceStart.SetActive(true);
        }
    }
}
