using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using Narrate;

public class StopSubtitles : MonoBehaviour {



	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public static void stopSubtitles(){
		SubtitleManager subMan = SubtitleManager.FindObjectOfType<SubtitleManager>();

		subMan.Stop();

	}

	public static void stopNarration() {
		NarrationManager narMan = NarrationManager.FindObjectOfType<NarrationManager>();
		narMan.GetComponent<AudioSource>().Stop();
	}
}
