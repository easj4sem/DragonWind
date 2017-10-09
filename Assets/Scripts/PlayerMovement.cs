using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D rigidbody2D;
    public float jumpForce;
    public float movingSpeed;
    public Vector3 xVector;
    public Vector3 yVector;

    // Use this for initialization
    void Start()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        movingSpeed = (float) 0.1;
        xVector = new Vector3(movingSpeed, 0, 0);
        yVector = new Vector3(0, movingSpeed, 0);
        //public var bullet : GameObject;

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key pressed. You killed a peasant.");
            //Instantiate(bullet)
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position -= xVector;
        }
	    if (Input.GetKey(KeyCode.RightArrow))
	    {
	        gameObject.transform.position += xVector;
	    }
        if (Input.GetKey((KeyCode.UpArrow)))
        {
            gameObject.transform.position += yVector;
        }
        if (Input.GetKey((KeyCode.DownArrow)))
        {
            gameObject.transform.position -= yVector;
        }
    }
}
