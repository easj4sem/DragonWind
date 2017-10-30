using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour {

    var MyAudio : AudioClip;

	// Use this for initialization
	void Start () {
	    AudioSource.PlayClipAtPoint(MyAudio(), transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
