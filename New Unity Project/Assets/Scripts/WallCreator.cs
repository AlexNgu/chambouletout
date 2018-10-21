using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCreator : MonoBehaviour {

	public int m_wallWidth;
	public int m_wallHeight;
	public Vector3 m_wallPosition;
	public float m_groundHeight;
	public GameObject m_brick;

	void Start () {
		Vector3 l_brickSize = m_brick.GetComponent<Transform>().lossyScale;
		float leftPosition = m_wallPosition.x - (m_wallWidth * l_brickSize.x / 2.0f);

		for (int i = 0; i < m_wallHeight; i++) {
			for (int j = 0; j < m_wallWidth; j++) {
				GameObject go = Instantiate(m_brick);
				go.GetComponent<Transform>().SetPositionAndRotation(
					new Vector3(
						leftPosition + l_brickSize.x / 2.0f + l_brickSize.x * j,
						m_wallPosition.y + l_brickSize.y / 2.0f + l_brickSize.y * i,
						m_wallPosition.z
					),
					new Quaternion()
				);
				go.name = "Cube" + (j + i * m_wallWidth);
			}
		}
	}
}
