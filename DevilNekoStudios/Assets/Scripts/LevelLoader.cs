using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public bool playerIsClose;
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
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("VictimsGame");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {

            StartCoroutine(loadLevel()); 
            //source.Play();
            //SceneManager.LoadScene("VictimsGame");
        }
    }


  


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerIsClose = false;
    }

}
