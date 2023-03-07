using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartChoiceScript : MonoBehaviour
{

    public bool playerIsClose;
    public GameObject yesChoice;
    public GameObject noChoice;
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
            yesChoice.SetActive(true);
            noChoice.SetActive(true);

        }
    }
}
