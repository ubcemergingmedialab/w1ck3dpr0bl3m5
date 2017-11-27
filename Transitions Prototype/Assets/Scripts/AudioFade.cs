using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFade : MonoBehaviour {
	private AudioSource[] a;
	private bool fade = false;

	public float audioSpeed = 0.6f;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			fade = true;
		}

		if (fade == true) {
			AudioFadeOut ();
		}
	}

	// Fades out all audio. Used for interviews atm
	void AudioFadeOut() {
		a = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];

		foreach (AudioSource audio in a) {
			if (audio.volume > 0.01f) {
				audio.volume -= audioSpeed * Time.deltaTime;
				//Debug.Log (audio.volume);
			} else {
				// Not the most efficient way atm.
				audio.Stop ();
				fade = false;
				audio.volume = 1;
				//Debug.Log ("Audio Switched");
			}
		}

	}
}
