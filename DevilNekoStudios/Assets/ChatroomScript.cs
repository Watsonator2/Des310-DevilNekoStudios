using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatroomScript : MonoBehaviour
{

    public GameObject chatroomIcon;
    public GameObject chatRoom;
    public GameObject nextInteract;

    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        
    }

   public void toggleChatroom()
    {
    
        if (chatRoom.activeInHierarchy)
        {
            source.Play();
            chatRoom.SetActive(false);
            if (!nextInteract.activeInHierarchy)
            {
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
