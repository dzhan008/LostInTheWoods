using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager> {

    public AudioSource musicSource;
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

    public void PlaySFX(string clipName)
    {
        AudioClip clip = (AudioClip)Resources.Load("Audio/SFX/" + clipName);
        GetComponent<AudioSource>().PlayOneShot(clip);
    }

    public void PlayTrack(string clipName)
    {
        musicSource.clip = (AudioClip)Resources.Load("Audio/Music/" + clipName);
        musicSource.Play();
    }
}
