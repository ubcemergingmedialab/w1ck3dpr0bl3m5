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

	public void stopSubtitles(){
		SubtitleManager subMan = SubtitleManager.FindObjectOfType<SubtitleManager>();
		NarrationManager narMan = NarrationManager.FindObjectOfType<NarrationManager>();
		subMan.Stop();
		narMan.GetComponent<AudioSource>().Stop();
	}
}
