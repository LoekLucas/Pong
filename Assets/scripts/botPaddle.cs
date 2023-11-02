using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class botPaddle : MonoBehaviour
{
    public float yPosition = 0f;
    public float ySpeed = 5f;
    public GameObject ball; // Asking for a game object that this code will be able to interact with


    // Update is called once per frame
    private void Update()
    {
        transform.position = new Vector3(transform.position.x, ball.transform.position.y, 0f); // Sets vertical position of paddle to be the same as the ball
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("horizontalWall")) // "If ball collided with an object with this tag"
        {
            ySpeed = ySpeed * -1f; // "Invert vertical speed and direction"
        }
    }
}
    
