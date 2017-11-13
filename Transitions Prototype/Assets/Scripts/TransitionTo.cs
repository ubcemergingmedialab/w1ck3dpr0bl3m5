using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionTo : MonoBehaviour {
	bool transition;
	public Animator animator;
	public GameObject target;
	public GameObject curSphere; 
	bool pressed;

	// Use this for initialization
	void Start () {
		if (animator == null) {
			animator = GetComponent<Animator>();
		}
		transition = false;	
		if (target == null) {
			target = GetComponent<GameObject>();
		}
		animator.SetTrigger("Init");
		pressed = false;
		//target = GetComponent<GameObject>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space") && !pressed){
			pressed = true;
			print("SPACE");
			animator.SetTrigger("Trans");
			Invoke ("createNewSphere", 2);
			Invoke ("destroySphere", 2);
			//Invoke (deleteSphere, 1);
		}
	}

	void createNewSphere(){
		GameObject nextPhotoShphere = (GameObject)Instantiate(target);
	}

	void destroySphere(){
		Destroy (curSphere); 
	}
}
