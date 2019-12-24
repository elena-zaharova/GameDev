using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMove : MonoBehaviour
{
    bool mouseDown = false;
    bool onFloor = false;
    public GameObject block;
    Vector3 pos;

    void OnCollisionEnter2D(Collision2D c)
    {
        switch (c.gameObject.name)
        {
            case "Main Block":
                onFloor = true;
                break;
            case "Vert1Block2":
                onFloor = true;
                break;
            case "Hor3Block2":
                onFloor = true;
                break;
            case "Vert2Block3":
                onFloor = true;
                break;
            case "Hor4Block2":
                onFloor = true;
                break;
            case "Vert2Block3 (1)":
                onFloor = true;
                break;
            case "Hor3Block2 (1)":
                onFloor = true;
                break;
            case "Vert1Block2 (1)":
                onFloor = true;
                break;
            case "Vert1Block2 (2)":
                onFloor = true;
                break;
            case "Hor2Block2":
                onFloor = true;
                break;
            case "Vert1Block3":
                onFloor = true;
                break;
            case "HorBlock3":
                onFloor = true;
                break;
            case "Hor1Block2":
                onFloor = true;
                break;
            default:
                break;
        }
    }

    void OnCollisionExit2D(Collision2D c)
    {
        switch (c.gameObject.name)
        {
            case "Main Block":
                onFloor = false;
                break;
            case "Vert1Block2":
                onFloor = false;
                break;
            case "Hor3Block2":
                onFloor = false;
                break;
            case "Vert2Block3":
                onFloor = false;
                break;
            case "Hor4Block2":
                onFloor = false;
                break;
            case "Vert2Block3 (1)":
                onFloor = false;
                break;
            case "Hor3Block2 (1)":
                onFloor = false;
                break;
            case "Vert1Block2 (1)":
                onFloor = false;
                break;
            case "Vert1Block2 (2)":
                onFloor = false;
                break;
            case "Hor2Block2":
                onFloor = false;
                break;
            case "Vert1Block3":
                onFloor = false;
                break;
            case "HorBlock3":
                onFloor = false;
                break;
            case "Hor1Block2":
                onFloor = false;
                break;
            default:
                break;
        }
    }

    void Start()
    {
        pos.x = block.transform.position.x;
    }

    void OnMouseDown()
    {
        mouseDown = true;
    }

    void OnMouseUp()
    {
        mouseDown = false;
        onFloor = false;
    }

    void Update()
    {
        Vector3 cursor = Input.mousePosition;
        cursor = Camera.main.ScreenToWorldPoint(cursor);
        cursor.z = 0;
        cursor.x = pos.x;
       

        if(mouseDown)
        {
            if ((Mathf.Round(cursor.y) >= 150) && (Mathf.Round(cursor.y) <= 1035))
            {
                if (!onFloor)
                {
                    this.transform.position = cursor;
                }
            }
           
        }

    }
}
