using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Unity.UI;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{

    public AudioSource[] sources;
   // public AudioSource sound1;
   // public AudioSource sound2;
    public GameObject DialougePanel;
    public Text DialougeText;
    public string[] dialouge;
    private int index;
    public GameObject[] portrait;
    public GameObject contButton;
    public float wordSpeed;
    public bool playerIsClose;
    public GameObject nextInteract;
    // Start is called before the first frame update
    void Start()
    {
        sources= GetComponents<AudioSource>();
       // sound1 = sources[0];
       // sound2 = sources[1];
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
        StopCoroutine(Typing());
        index = 0;
        DialougeText.text = "";
        DialougePanel.SetActive(false);
 
    }
    IEnumerator Typing()
    {
        foreach(char letter in dialouge[index].ToCharArray())
        {
            if (!sources[0].isPlaying)
            {
                sources[0].Play();
            }
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
            portrait[index - 1].SetActive(false);
            portrait[index].SetActive(true);
            StartCoroutine(Typing());
        }

        else
        {
            nextInteract.SetActive(true);
            zeroText();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            if (!DialougePanel.activeInHierarchy)
            {
                sources[1].Play();
                DialougePanel.SetActive(true);
                portrait[index].SetActive(true);
                StartCoroutine(Typing());
            }

            else if (DialougeText.text == dialouge[index])
            {
                sources[1].Play();
                nextLine();
            }

            if(Input.GetKeyDown(KeyCode.Q) && DialougePanel.activeInHierarchy)
            {
                zeroText();
            }
            //if (DialougePanel.activeInHierarchy)
            //{
            //    zeroText();
            //}

            //else
            //{
            //    DialougePanel.SetActive(true);
            //    StartCoroutine(Typing());
            //}

            //if(DialougeText.text == dialouge[index])
            //{
            //    contButton.SetActive(true);
            //}
        }
    }
}
