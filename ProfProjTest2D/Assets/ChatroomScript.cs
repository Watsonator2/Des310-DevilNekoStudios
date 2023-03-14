using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatroomScript : MonoBehaviour
{

    public GameObject chatroomIcon;
    public GameObject chatRoom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //    if (chatRoom.activeInHierarchy)
    //    {
    //        chatRoom.SetActive(false);
    //    }

    //    if (!chatRoom.activeInHierarchy)
    //    {
    //        chatRoom.SetActive(true);
    //    }
        
    }

   public void toggleChatroom()
    {
        if (chatRoom.activeInHierarchy)
        {
            chatRoom.SetActive(false);
        }

        else if (!chatRoom.activeInHierarchy)
        {
            chatRoom.SetActive(true);
        }

    }
}
