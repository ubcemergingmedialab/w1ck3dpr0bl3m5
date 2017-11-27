using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TransitionTo : MonoBehaviour {
	public GameObject target;
	bool transitioning;
	Animator fader;
	void Start () {
		if (target == null) {
			target = GetComponent<GameObject>(); //Gets the sphere that you're transitioning to
		}
		EventTrigger trigger = GetComponent<EventTrigger>();
		transitioning = false; //This keeps the transitionTo from being run while already transitioning
		fader = GameObject.Find("Fader").GetComponent<Animator>(); //The animator of the black rectangle that makes the fade
	}
		

	public void doTransition(){
		if (!transitioning) {
			transitioning = true;
			fader.SetTrigger ("Fader In");
			Invoke ("createNewSphere", 2);
			Invoke ("destroySphere", 2);
			Invoke ("fadeOut", 2);
		}
	}

	void fadeOut(){
		fader.SetTrigger("Fader Out");
	}
	void createNewSphere(){
		GameObject nextPhotoShphere = (GameObject)Instantiate(target); //This var isn't used but not declaring it makes it not work
	}

	void destroySphere(){
		Destroy (transform.parent.gameObject); 
	}
}
