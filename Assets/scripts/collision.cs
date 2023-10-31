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
    public TMP_Text scoreText;
    public int leftScore = 0;
    public int rightScore = 0;
    public int winScore = 10;

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
        if (leftScore >= winScore)
        {
            scoreText.text = "Left player has won!";
            xPosition = 0f;
            yPosition = 0f;
        }
        else if (rightScore >= winScore)
        {
            scoreText.text = "Right player has won!";
            xPosition = 0f;
            yPosition = 0f;
        }
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
            rightScore = rightScore + 1;
            xSpeed = 2f;
            ySpeed = 2f;

            scoreText.text = leftScore + " - " + rightScore;
            Debug.Log("Left scored!");
        }

        else if (collision.gameObject.CompareTag("tpTriggerLeft"))
        {
            xPosition = 0f;
            yPosition = 0f;
            leftScore = leftScore + 1;
            xSpeed = 2f;
            ySpeed = 2f;

            scoreText.text = leftScore + " - " + rightScore;
            Debug.Log("Right scored!");
        }

        else if (collision.gameObject.CompareTag("verticalWall"))
        {
            xSpeed = xSpeed * -1.1f;
            ySpeed = ySpeed * 1.1f;

        }
    }
}
