using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionTo : MonoBehaviour {
	public GameObject target;
	bool transitioning;
	Animator fader;

	// Use this for initialization
	void Start () {
		if (target == null) {
			target = GetComponent<GameObject>(); //Gets the sphere that you're transitioning to
		}
		transitioning = false; //This keeps the transitionTo from being run while already transitioning
		fader = GameObject.Find("Fader").GetComponent<Animator>(); //The animator of the black rectangle that makes the fade
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space") && !transitioning){
			transitioning = true;
			fader.SetTrigger("Fader In");
			Invoke("createNewSphere", 2);
			Invoke("destroySphere", 2);
			Invoke("fadeOut", 2);
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
