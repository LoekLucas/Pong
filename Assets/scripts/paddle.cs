using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class paddle : MonoBehaviour
{
    public float speed = 3f;
    public string leftOrRight;
    public float maxYValue = 4f;

    void paddleControl(KeyCode up,KeyCode down)
    {
        if (Input.GetKey(up) && transform.position.y < maxYValue)
        {
            Debug.Log("Yo");
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down) && transform.position.y > -maxYValue)
        {
            Debug.Log(":3");
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (leftOrRight == "left")
        {
            paddleControl(KeyCode.W, KeyCode.S);
        }
        else if (leftOrRight == "right")
        {
            paddleControl(KeyCode.UpArrow, KeyCode.DownArrow);
        }
    }
}
