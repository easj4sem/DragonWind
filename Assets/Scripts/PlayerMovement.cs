using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    //private Rigidbody2D rigidbody2D;
    public float jumpForce;
    public float movingSpeed;
    public Vector3 xVector;
    public Vector3 yVector;

    public GameObject bullet;
    public Transform shotSpawn;

    public AudioSource fireSound;

    // Use this for initialization
    void Start()
    {
        movingSpeed = (float) 0.1;
        xVector = new Vector3(movingSpeed, 0, 0);
        yVector = new Vector3(0, movingSpeed, 0);
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position -= xVector;
        }
	    if (Input.GetKey(KeyCode.RightArrow))
	    {
	        gameObject.transform.position += xVector;
	    }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.position += yVector;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.position -= yVector;
        }
    }

    private void Fire()
    {
        Instantiate(bullet, shotSpawn.position, shotSpawn.rotation);
        AudioSource.PlayClipAtPoint(fireSound.clip, transform.position);
    }
}
