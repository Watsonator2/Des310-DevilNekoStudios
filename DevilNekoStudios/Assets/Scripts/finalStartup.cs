using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalStartup : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject finalText;
    void Start()
    {
        finalText.SetActive(true);
        StartCoroutine(finalWait());

    }

    IEnumerator finalWait()
    {
        yield return new WaitForSeconds(4.0f);
        finalText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
