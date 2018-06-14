using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager> {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Play(string clipName)
    {
        GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("Audio/Dialogue/" + clipName);
        GetComponent<AudioSource>().Play();
    }
}
