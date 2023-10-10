using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class counter : MonoBehaviour
{
    collision collision;
    public TMP_Text scoreLeftDisplay;
    public TMP_Text scoreRightDisplay;
    //private Collider2D ball;

    // Start is called before the first frame update
    void Awake()
    {
       // ball = GameObject.Find("ball").GetComponent<collision>();
    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (collision.gameObject.CompareTag("scoreLeftDisplayTag")) 
        {
            //scoreLeftDisplay = collision.scoreLeft.ToString();
            Debug.Log("yes left score");
        }

        else if (gameObject.CompareTag("scoreRightDisplayTag"))
        {
            //scoreLeftDisplay = collision.scoreLeft.ToString();
            Debug.Log("yes right score");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

}
