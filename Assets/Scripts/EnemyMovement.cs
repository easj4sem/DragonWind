﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Vector3 xVector;
    private Vector3 yVector;
    private float movingSpeed;
    private int jumpCount;


    // Use this for initialization
    void Start () {
        movingSpeed = (float)0.005;
        xVector = new Vector3(movingSpeed, 0, 0);
        yVector = new Vector3(0, 1f, 0);
        jumpCount = 0;

    }
	
	// Update is called once per frame
	void Update () {
	    gameObject.transform.position -= xVector;
	    if (jumpCount++ == 500)
	    {
	        gameObject.transform.position += yVector;
	        jumpCount = 0;
        }
	}
}
