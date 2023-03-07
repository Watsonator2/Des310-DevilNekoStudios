using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderGame : MonoBehaviour { 
    public bool playerIsClose;
// Update is called once per frame
void Update()
{
    if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
    {
        SceneManager.LoadScene("VictimsDesktop");
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
