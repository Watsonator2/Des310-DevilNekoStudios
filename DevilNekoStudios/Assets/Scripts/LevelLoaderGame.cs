using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderGame : MonoBehaviour { 
    public bool playerIsClose;
    public AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    IEnumerator loadNextScene()
    {
        source.Play();
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Final Desktop");
    }
    // Update is called once per frame
    void Update()
{
    if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
    {
            StartCoroutine(loadNextScene());
        
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
