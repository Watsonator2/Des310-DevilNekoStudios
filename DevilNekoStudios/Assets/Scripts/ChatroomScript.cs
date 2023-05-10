using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatroomScript : MonoBehaviour
{

    public GameObject chatroomIcon;
    public GameObject chatRoom;
    public GameObject nextInteract;
    public GameObject nextText;

    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (nextText.activeInHierarchy)
        {
            targetText.SetActive(false);
        }
        
    }

    public GameObject targetText;
    public int timeDisplayed;

    IEnumerator startText()
    {
        targetText.SetActive(true);
        yield return new WaitForSeconds(timeDisplayed);
        targetText.SetActive(false);

    }


    public void toggleChatroom()
    {
    
        if (chatRoom.activeInHierarchy)
        {
            source.Play();
            chatRoom.SetActive(false);
            if (!nextInteract.activeInHierarchy)
            {
                StartCoroutine(startText());
                nextInteract.SetActive(true);
            }
        }

        else if (!chatRoom.activeInHierarchy)
        {
            source.Play();
            chatRoom.SetActive(true);
        }

    }
}
