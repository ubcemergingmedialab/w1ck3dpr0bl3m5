using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fanciness : MonoBehaviour {

    public Transform thing;
    bool rotate_active;

	// Use this for initialization
	void Start () {
        thing = GetComponent<Transform>();
        rotate_active = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (rotate_active)
        {
            thing.Rotate(Vector3.up * 50 * Time.deltaTime);
        }
	}

    public void setRotate(bool rotate)
    {
        rotate_active = rotate;
    }
}
