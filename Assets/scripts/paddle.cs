using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlle : MonoBehaviour
{
    // Variables
    public float speed = 3f;
    public string leftOrRight;
    public float maxValue = 4f;


    void paddleControl(KeyCode up, KeyCode down) // Makes a keycode for up and down which you can assign keys too
    {
        if (Input.GetKey(up) && transform.position.y < maxValue) // "If up key pressed and position you're trying to go to is less than maxValue"
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime); // "Go up by the value of speed"

        }
        else if (Input.GetKey(down) && transform.position.y > -maxValue) // "If down key is pressed and position you're trying to go to is more than -maxValue"
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime); // "Go down by the value of speed"
        }
    }

    void Update()
    {
        if (leftOrRight == "left")
        {
            paddleControl(KeyCode.W, KeyCode.S); // Sets keycode up/down to W/S
        }
        else if (leftOrRight == "right")
        {
            paddleControl(KeyCode.UpArrow, KeyCode.DownArrow); // Sets keycode up/down to up arrow/down arrow
        }

    }
}