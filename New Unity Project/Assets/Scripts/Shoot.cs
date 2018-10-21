using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public float m_velocity;
	public GameObject m_sphere;
	public Material m_material1;
	public Material m_material2;

	void Update () {

			if (Input.GetMouseButtonDown(0)) {
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				GameObject go =Instantiate(m_sphere,
					Camera.main.GetComponent<Transform>().position + ray.direction,
					Camera.main.GetComponent<Transform>().rotation
				);
				go.GetComponent<Rigidbody>().velocity = ray.direction * m_velocity;
				int rnd = (int) (Random.value * 100);
				if (rnd % 2 == 0) { go.GetComponent<Renderer>().material = m_material1; }
				else { go.GetComponent<Renderer>().material = m_material2; }
			}
	}
}
