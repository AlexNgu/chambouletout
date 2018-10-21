using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenLow : MonoBehaviour {

	void Update () {
		if (gameObject.GetComponent<Transform>().position.y < -20) {
			Destroy(gameObject);
		}
	}
}
