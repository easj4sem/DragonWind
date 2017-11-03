using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour
{
    private Vector3 xVector;
    private Vector3 yVector;
    private float movingSpeed;
    private int jumpCount;

    public AudioSource HitSound;
    public int highScore;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger", gameObject);
        Destroy(this.gameObject);
        if (other.name != "Destroyer")
        {
            Destroy(other.gameObject);
            highScore++;
            GameObject.FindGameObjectWithTag("Score").GetComponent<Text>().text = "Score: " + highScore;
        }
        
        AudioSource.PlayClipAtPoint(HitSound.clip,transform.position);
    }


    // Use this for initialization
    void Start () {
        movingSpeed = (float)0.005;
        xVector = new Vector3(movingSpeed, 0, 0);
        yVector = new Vector3(0, 1f, 0);
        jumpCount = 0;
        HitSound = GetComponent<AudioSource>();
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
