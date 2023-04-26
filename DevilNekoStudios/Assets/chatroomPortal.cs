using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chatroomPortal : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }


    public void wrapper()
    {
        StartCoroutine(loadLevel());
    }
    IEnumerator loadLevel()
    {
        source.Play();
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("ChatroomScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
