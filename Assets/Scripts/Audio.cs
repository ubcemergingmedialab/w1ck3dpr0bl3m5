using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {
	private bool isPlaying;
	public AudioSource myAudioSource; 
	GameObject interviewButton;

	void Start () {
		isPlaying = false;
		//myAudioSource = GetComponents<AudioSource> ();
	}

	public void controlAudio () {
		if (isPlaying == true) {
			myAudioSource.Stop ();
			isPlaying = false;
		} else {
			myAudioSource.Play ();
			isPlaying = true;
		}
	}
}
