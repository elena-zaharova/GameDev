using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorisonMove : MonoBehaviour
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
            default:
                break;
        }
    }

    void OnCollisionExit2D(Collision2D c)
    {
        switch(c.gameObject.name)
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
            default:
                break;
        }
    }

    void Start()
    {
        pos.y = block.transform.position.y;
    }

    void OnMouseDown()
    {
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
        cursor.y = pos.y;

        if (mouseDown)
        {
            if ((Mathf.Round(cursor.x) >= 140) && (Mathf.Round(cursor.x) <= 574))
            {
                if (!onFloor)
                {
                    this.transform.position = cursor;
                    onFloor = false;
                }

            }
        }

    }
}
