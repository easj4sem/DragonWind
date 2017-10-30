using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public int lifespan;
    public Vector3 yVector;

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
