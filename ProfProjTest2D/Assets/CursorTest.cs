using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorTest : MonoBehaviour
{
    Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseReal = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos = Input.mousePosition;

        transform.position = mouseReal;
    }
}
