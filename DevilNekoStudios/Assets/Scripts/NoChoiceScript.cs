using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NoChoiceScript : MonoBehaviour
{
    public bool playerIsClose;
    public AudioSource source;

    private void Start()
    {
        source= GetComponent<AudioSource>();
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
        if (collision.CompareTag("Player"))
        {
            playerIsClose = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsClose && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("NoChoiceScene");
            Debug.Log("No Choosen");
        }
    }


    IEnumerator noChoiceCo()
    {
        source.Play();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("NoChoiceScene");
    }
    public void noChoice()
    {
        StartCoroutine(noChoiceCo());
    }
}
