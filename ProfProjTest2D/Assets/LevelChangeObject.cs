using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChangeObject : MonoBehaviour
{
    LevelLoader levelLoader;
    public bool playerIsClose;

    private void Start()
    {
    
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
