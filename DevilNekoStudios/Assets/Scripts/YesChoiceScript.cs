using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YesChoiceScript : MonoBehaviour
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
            SceneManager.LoadScene("YesChoiceScene");
            Debug.Log("Yes Choosen");
        }
    }


    IEnumerator yesChoiceCo()
    {
        source.Play();
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("YesChoiceScene");
    }
    public void yesChoice()
    {
    StartCoroutine(yesChoiceCo());
    }
}

