using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float xPosition = 0f;
    public float yPosition = 0f;
    public float xSpeed = 2f;
    public float ySpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(2f,2f,0f);
        
    }

    // Update is called once per frame
    void Update()
    { 
        xPosition = xPosition + xSpeed * Time.deltaTime;
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);  
    }
}
