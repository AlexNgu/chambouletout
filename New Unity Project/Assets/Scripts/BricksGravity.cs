using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksGravity : MonoBehaviour {

	void Update () {
		if (Input.GetKey("up")) {
			gameObject.GetComponent<Rigidbody>().useGravity = false;
		} else if (Input.GetKey("down")) {
			gameObject.GetComponent<Rigidbody>().useGravity = true;
		}
	}
}
