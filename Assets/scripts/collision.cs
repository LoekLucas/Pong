using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class collision : MonoBehaviour
{
    public float xPosition = 2f;
    public float yPosition = 2f;
    public float xSpeed = 2f;
    public float ySpeed = 2f;
    public float scoreRight = 0f;
    public float scoreLeft = 0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(2f, 2f, 0f);

    }

    // Update is called once per frame
    void Update()
    {
        xPosition = xPosition + xSpeed * Time.deltaTime;
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            ySpeed = ySpeed * -1f;
        }

        else if (collision.gameObject.CompareTag("verticalWall"))
        {
            xSpeed = xSpeed * -1f;
        }

        else if (collision.gameObject.CompareTag("tpTriggerRight"))
        {
            xPosition = 0f;
            yPosition = 0f;
        }

        else if (collision.gameObject.CompareTag("tpTriggerLeft"))
        {
            xPosition = 0f;
            yPosition = 0f; 
        }
    }
}
