using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using TMPro;

public class collision : MonoBehaviour
{
    public float xPosition = 0f;
    public float yPosition = 0f;
    public float xSpeed = 2f;
    public float ySpeed = 2f;
    public int scoreRight = 0;
    public int scoreLeft = 0;
    public TMP_Text scoreTextRight;
    public TMP_Text scoreTextLeft;
    public float winCondition = 10f;

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

        else if (collision.gameObject.CompareTag("tpTriggerRight"))
        {
            xPosition = 0f;
            yPosition = 0f;
            scoreRight = scoreRight + 1;
            xSpeed = 2f;
            ySpeed = 2f;

            Debug.Log("Left scored!");
        }

        else if (collision.gameObject.CompareTag("tpTriggerLeft"))
        {
            xPosition = 0f;
            yPosition = 0f;
            scoreLeft = scoreLeft + 1;
            xSpeed = 2f;
            ySpeed = 2f;

            Debug.Log("Right scored!");
        }

        else if (collision.gameObject.CompareTag("verticalWall"))
        {
            xSpeed = xSpeed * -1.1f;
            ySpeed = ySpeed * 1.1f;

        }

        

    }
}
