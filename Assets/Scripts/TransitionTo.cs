using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionTo : MonoBehaviour {
	public GameObject target;
	public static bool TRANSITIONTO_TRANSITIONING;
	Animator fader;
	private float audioSpeed = 1;
	AudioFade audiofade;
	// Use this for initialization
	void Start () {
		if (target == null) {
			target = GetComponent<GameObject>(); //Gets the sphere that you're transitioning to
        }
		TRANSITIONTO_TRANSITIONING = false; //This keeps the transitionTo from being run while already transitioning
		fader = GameObject.Find("Fader").GetComponent<Animator>(); //The animator of the black rectangle that makes the fade
		audiofade = GameObject.Find("AudioFader").GetComponent<AudioFade>();
    }



	public void doTransition(){
		if (!TRANSITIONTO_TRANSITIONING){
			TRANSITIONTO_TRANSITIONING = true;

			fader.SetTrigger("Fader In");
			Invoke("createNewSphere", 2);
			Invoke("destroySphere", 2);
			Invoke("fadeOut", 2);
			//StopSubtitles.stopSubtitles();
			audiofade.fade = true;
		}

		//AudioListener.volume = 0;
		//StopSubtitles.stopNarration();
	}

	void fadeOut(){
		fader.SetTrigger("Fader Out");
	}
	void createNewSphere(){
		GameObject nextPhotoSphere = (GameObject)Instantiate(target); //This var isn't used but not declaring it makes it not work
		//StopSubtitles.stopNarration();
		audiofade.fade = false;
		audiofade.unFade();

	}

	void destroySphere(){
		Destroy (transform.parent.gameObject); 
	}

	/*void stopSubtitles(){
		SubtitleManager subMan = SubtitleManager.FindObjectOfType<SubtitleManager>();
		NarrationManager narMan = NarrationManager.FindObjectOfType<NarrationManager>();
		subMan.Stop();
		narMan.GetComponent<AudioSource>().Stop();
	}*/
}
