using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using TMPro;

public class collision : MonoBehaviour
{
    // Variables
    public float xPosition = 0f;
    public float yPosition = 0f;
    public float xSpeed = 2f;
    public float ySpeed = 2f;
    public TMP_Text scoreText;
    public int leftScore = 0;
    public int rightScore = 0;
    public int winScore = 10;


    void Start()
    {
        transform.position = new Vector3(2f, 2f, 0f); // Sets the balls position when called
    }

    void Update()
    {
        // Updates the ball's position using the speed variables
        xPosition = xPosition + xSpeed * Time.deltaTime; 
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);

        // Reads both player's scores and stops the game if either is 10 or higher and congratulates the winner
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
        
        // If the ball collided with an object with this tag, invert vertical speed and direction
        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            ySpeed = ySpeed * -1f;
        }

        // If the ball collided with an object with this tag, reset the ball to the center of the screen, set both speeds to 3 and give the Left player a point
        else if (collision.gameObject.CompareTag("tpTriggerRight"))
        {
            xPosition = 0f;
            yPosition = 0f;
            leftScore = leftScore + 1;
            xSpeed = 3f;
            ySpeed = 3f;

            scoreText.text = leftScore + " - " + rightScore;
        }

        // If the ball collided with an object with this tag, reset the ball to the center of the screen, set both speeds to 3 and give the Right player a point
        else if (collision.gameObject.CompareTag("tpTriggerLeft"))
        {
            xPosition = 0f;
            yPosition = 0f;
            rightScore = rightScore + 1;
            xSpeed = 3f;
            ySpeed = 3f;

            scoreText.text = leftScore + " - " + rightScore;
        }

        // If the ball collided with an object with this tag, invert both vertical and horizontal speed and direction
        else if (collision.gameObject.CompareTag("verticalWall"))
        {
            xSpeed = xSpeed * -1.1f;
            ySpeed = ySpeed * 1.1f;

        }
    }
}
