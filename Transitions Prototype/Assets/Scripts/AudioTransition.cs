using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTransition : MonoBehaviour {

	private AudioSource[] allAudioSources;

	public AudioSource audio;
	public AudioSource audio1;

	bool playNext = false;
	bool crossFade = false;

	bool switchAudio = false; 	// temporary

	void Update () {
		if (Input.GetKeyDown ("space")) {
			//StopAllAudio ();
			playNext = true;
			crossFade = true;

			switchAudio = (!switchAudio);	// temporary
		}

		if (crossFade && switchAudio) {
			CrossFade (audio, audio1);
		} else {
			CrossFade (audio1, audio);
		}
	}

	// Audio A will fade out as Audio B fade in
	void CrossFade(AudioSource a, AudioSource b) {

		if (playNext == true) {
			b.Play ();
			playNext = false;
		}

		if (a.volume > 0f) {
			a.volume -= 0.2f * Time.deltaTime;
		} else {
			a.Stop ();
		}

		if (b.volume < 1f) {
			b.volume += 0.1f * Time.deltaTime;
		} else {
			crossFade = false;
		}
	}
		
	// Stops all audios
	void StopAllAudio() {
		allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
		float audioVolume = 0;

		foreach(AudioSource audio in allAudioSources) {
			audio.Stop ();
		}
	}
}
