using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    private int Countdown;
    private Vector3 position;

    public int countTo;

    public GameObject Enemy;

	// Use this for initialization
	void Start ()
	{
	    Countdown = countTo;
        position = new Vector3(transform.position.x, transform.position.y);
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (Countdown-- <= 0)
	    {
	        Instantiate(Enemy, transform);
	        Countdown = countTo;
	    }


	}


}
