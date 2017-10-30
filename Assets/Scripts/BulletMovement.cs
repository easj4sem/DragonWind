using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public int lifespan;
    public Vector3 yVector;

    //void OnCollisionEnter2D(Collision2D other)
    //{
    //    // maybe make an array with killable objects
    //    Debug.Log("Collision", gameObject);

    //    Destroy(other.gameObject);
    //}

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    Debug.Log("Trigger", gameObject);
    //    Destroy(other.gameObject);
    //}

    // Use this for initialization
    void Start () {
		yVector = new Vector3(0.15f,0,0);
	    lifespan = 100;
	}
	
	// Update is called once per frame
	void Update () {
	    gameObject.transform.position += yVector;

        if (lifespan-- <= 0) { Destroy(gameObject); }
	}
}
