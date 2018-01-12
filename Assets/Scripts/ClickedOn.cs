using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickedOn : MonoBehaviour {
	RaycastHit hit;
	Ray ray;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1")) {
			hit = new RaycastHit();
			Debug.Log ("click");
			ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast(ray, out hit, 100)) {
				if (hit.transform.name == this.transform.name) {
					Debug.Log ("My object is clicked by mouse");
				}
			}
		}
	}
}
