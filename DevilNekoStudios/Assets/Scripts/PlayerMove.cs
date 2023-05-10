using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    Vector2 playerMove;
    private AudioSource source;
    private float xMin, xMax;
    private float yMin, yMax;

    [SerializeField] private float rightBound = 0f;
    [SerializeField] private float leftBound = 0f;
    [SerializeField] private float topBound = 0f;
    [SerializeField] private float bottomBound = 0f;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();

        //obtaining variables to clamp movement

        var spriteSize = GetComponent<SpriteRenderer>().bounds.size.x * 0.5f;

        var camera = Camera.main;

        var cameraHeight = camera.orthographicSize;
        var camWidth = camera.orthographicSize * camera.aspect;

        //gets upper and lower bounds
        yMin = -cameraHeight + spriteSize;
        yMax = cameraHeight - spriteSize;

        xMin = -camWidth + spriteSize;
        xMax = camWidth - spriteSize;

        
    }

    // Update is called once per frame
    void Update()
    {
        playerBoundaries();
        playerMove = transform.position;
        float postUpdateX = Input.GetAxis("Horizontal") * Time.deltaTime;
       // float postUpdateY = Input.GetAxis("Vertical") * Time.deltaTime;

        if(Input.GetAxis("Horizontal") < 0 || Input.GetAxis("Horizontal") > 0)
        {
            if(source.isPlaying == false)
            {
                source.Play();
            }
        }


       // if (Input.GetAxis("Vertical") < 0 || Input.GetAxis("Vertical") > 0)
    //    {
       //     if (source.isPlaying == false)
    //        {
      //          source.Play();
       //     }
    //    }

       // var direction = new Vector2(postUpdateX, postUpdateY).normalized;
       // direction *= 5.0f * Time.deltaTime;

       // var xValidPosition = Mathf.Clamp(transform.position.x + direction.x, xMin, xMax);
       // var yValidPosition = Mathf.Clamp(transform.position.y + direction.y, yMin, yMax);

       playerMove.x += postUpdateX * 5.0f;
      // playerMove.y += postUpdateY * 5.0f;

        transform.position = playerMove;
       // transform.position = new Vector3(xValidPosition,yValidPosition,0);
    }


    private void playerBoundaries()
    {
        float xMoveClamp = Mathf.Clamp(transform.position.x, leftBound, rightBound);
        float yMoveClamp = Mathf.Clamp(transform.position.y, bottomBound, topBound);
        Vector3 clampMovement = new Vector3(xMoveClamp, yMoveClamp, 0);
        transform.position = clampMovement;
    }

}
