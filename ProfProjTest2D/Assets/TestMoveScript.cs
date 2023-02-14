using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class TestMoveScript : MonoBehaviour
{

    Vector2 playerMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMove = transform.position;
        float postUpdateX = Input.GetAxis("Horizontal") * Time.deltaTime*2f;
        float postUpdateY = Input.GetAxis("Vertical") * Time.deltaTime*2f;

        playerMove.x += postUpdateX * 3.0f;
        playerMove.y += postUpdateY * 3.0f;
        
        transform.position = playerMove;
    }


}
