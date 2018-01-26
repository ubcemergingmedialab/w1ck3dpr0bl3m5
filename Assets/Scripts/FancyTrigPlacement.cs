using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FancyTrigPlacement : MonoBehaviour {
	public int startProblem;

	private int total;
	private GameObject menu;
	private Transform[] transformList;
	private float x;
	private float z;
	private float radius;
	private bool done;
	private List<int> problemList = new List<int> {1,2,4,5};

	// Use this for initialization
	void Start () {
		startProblem = problemList.IndexOf(startProblem);
		menu = GameObject.Find("Menu");
		if (menu == null) {
			menu = GameObject.Find("Menu(Clone)");
		}
		transformList = menu.GetComponentsInChildren<Transform>();
		total = transformList.Length;
		radius = 56.8f;
		// for whatever weird reason unity gets the parent when you call GetComponentsInChildren, so i starts at 1, and total is total-1 
		for (int i = 1; i < total; i++) {
			// -1 to flip direction
			float theta = (float) (- 1 * (i + 2 * startProblem + 0.5) * (2 * Mathf.PI) / (total - 1) + Mathf.PI);
			x = radius * Mathf.Cos(theta);
			z = radius * Mathf.Sin(theta);
			transformList[i].position = new Vector3(x, 0, z);
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
