using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counter : MonoBehaviour
{
    collision collision;
    public Text scoreLeftDisplay;
    public Text scoreRightDisplay;


    // Start is called before the first frame update
    void Awake()
    {
        collision = GameObject.Find("ball").GetComponent<collision>();
    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("scoreLeftDisplayTag")) 
        {
            ;
            scoreLeftDisplay = collision.scoreLeft.ToString();
        }

        else if (gameObject.CompareTag("scoreRightDisplayTag"))
        {
            scoreLeftDisplay = collision.scoreLeft.ToString();
        }
    }
  
}
