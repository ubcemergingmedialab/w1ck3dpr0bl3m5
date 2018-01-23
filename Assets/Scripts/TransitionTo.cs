using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionTo : MonoBehaviour {
	public GameObject target;
	public static bool TRANSITIONTO_TRANSITIONING;
	Animator fader;
	GameObject glass;


	// Use this for initialization
	void Start () {
		if (target == null) {
			target = GetComponent<GameObject>(); //Gets the sphere that you're transitioning to
        }
		TRANSITIONTO_TRANSITIONING = false; //This keeps the transitionTo from being run while already transitioning
		fader = GameObject.Find("Fader").GetComponent<Animator>(); //The animator of the black rectangle that makes the fade
        glass = GameObject.Find("Glass"); //Gets the glass, which is assumed to be the last object in the hierarchy
    }


	public void doTransition(){
		if (!TRANSITIONTO_TRANSITIONING){
			TRANSITIONTO_TRANSITIONING = true;

			fader.SetTrigger("Fader In");
			foreach (Animator a in (glass.GetComponentsInChildren<Animator>())) {
				a.SetTrigger("Fader Out");
			}
			Invoke("createNewSphere", 2);
			Invoke("destroySphere", 2);
			Invoke("fadeOut", 2);
			//hide.SetActive(false);
		}
	}

	void fadeOut(){
		fader.SetTrigger("Fader Out");
		foreach (Animator a in (glass.GetComponentsInChildren<Animator>())) {
			a.SetTrigger("Fader In");
		}
	}
	void createNewSphere(){
		GameObject nextPhotoSphere = (GameObject)Instantiate(target); //This var isn't used but not declaring it makes it not work
		//hide.SetActive(true);
	}

	void destroySphere(){
		Destroy (transform.parent.gameObject); 
	}
}
