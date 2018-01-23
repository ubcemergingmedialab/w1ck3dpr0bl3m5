using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFade : MonoBehaviour {
	public bool fade = false;

	public float audioSpeed = 1f;

	// Update is called once per frame
	void Update () {
		if (fade) {
			if (AudioListener.volume > 0) {
				AudioListener.volume -= audioSpeed * Time.deltaTime;
			}
		}
	}

	public void unFade(){
		AudioListener.volume = 1;
	}
		
}
