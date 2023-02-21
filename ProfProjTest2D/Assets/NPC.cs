using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{

    public GameObject DialougePanel;
    public Text DialougeText;
    public string[] dialouge;
    private int index;
    public GameObject contButton;
    public float wordSpeed;
    public bool playerIsClose;
    // Start is called before the first frame update
    void Start()
    {
        DialougeText.text = "";
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
            zeroText();
        }
    }

    public void zeroText()
    {
        DialougeText.text = "";
        index = 0;
        DialougePanel.SetActive(false);
    }
    IEnumerator Typing()
    {
        foreach(char letter in dialouge[index].ToCharArray())
        {
            DialougeText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void nextLine()
    {

        contButton.SetActive(false);
        if (index < dialouge.Length - 1)
        {
            index++;
            DialougeText.text = "";
            StartCoroutine(Typing());
        }

        else
        {
            zeroText();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            if (DialougePanel.activeInHierarchy)
            {
                zeroText();
            }

            else
            {
                DialougePanel.SetActive(true);
                StartCoroutine(Typing());
            }

            if(DialougeText.text == dialouge[index])
            {
                contButton.SetActive(true);
            }
        }
    }
}
