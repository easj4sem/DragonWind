using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

    public Vector3 yVector;

	// Use this for initialization
	void Start () {
		yVector = new Vector3(0.15f,0,0);
	}
	
	// Update is called once per frame
	void Update () {
	    gameObject.transform.position += yVector;
    }
}
