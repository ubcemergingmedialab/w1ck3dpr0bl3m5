using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaceInterview : MonoBehaviour {


	public void replace(){
		GameObject nextInterview = (GameObject)Instantiate(gameObject);
		GameObject sphere = gameObject.transform.parent.gameObject;
		nextInterview.transform.position = nextInterview.transform.position * 100;
		nextInterview.transform.parent = sphere.transform;
		nextInterview.transform.localScale = nextInterview.transform.localScale * 100;
		GameObject.Destroy(gameObject);
	}
		
}
