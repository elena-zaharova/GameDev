using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMove : MonoBehaviour
{
    bool mouseDown = false;
    public GameObject block;
    Vector3 pos;

    void Start()
    {
        pos.x = block.transform.position.x;
    }

    void OnMouseDown()
    {
        Debug.Log("DOWN");
        mouseDown = true;
    }

    void OnMouseUp()
    {
        mouseDown = false;
    }

    void Update()
    {
        Vector3 cursor = Input.mousePosition;
        cursor = Camera.main.ScreenToWorldPoint(cursor);
        cursor.z = 0;
        cursor.x = pos.x;

        if(mouseDown)
        {
            
            Debug.Log(cursor);
            Debug.Log(block);
            this.transform.position = cursor;
        }

    }
}
