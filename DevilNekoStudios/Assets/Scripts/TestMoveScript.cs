using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMoveScript : MonoBehaviour
{

    Vector2 playerMove;
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMove = transform.position;
        float postUpdateX = Input.GetAxis("Horizontal") * Time.deltaTime*2f;
        float postUpdateY = Input.GetAxis("Vertical") * Time.deltaTime*2f;

        if(Input.GetAxis("Horizontal") < 0 || Input.GetAxis("Horizontal") > 0)
        {
            if(source.isPlaying == false)
            {
                source.Play();
            }
        }


        if (Input.GetAxis("Vertical") < 0 || Input.GetAxis("Vertical") > 0)
        {
            if (source.isPlaying == false)
            {
                source.Play();
            }
        }


        playerMove.x += postUpdateX * 3.0f;
        playerMove.y += postUpdateY * 3.0f;
        
        transform.position = playerMove;
    }


}
