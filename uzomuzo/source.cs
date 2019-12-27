using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class source: MonoBehaviour {
	private Vector3 position;
	float x = 0.0f;
	float y = 0.0f;
	float z = 0.0f;
	//public float m_moveSpeed = 115f;
	//public float m_radius = 1000f;
	void Start () {	
		transform.position = new Vector3 (x,y,z);

	}
	void Update () {
		
		
		MoveToCircle ();
	}
	void MoveToCircle(){
		float a = 0.0f;
		float b = 0.0f;
		float c = 0.0f;
		if (Input.GetKey (KeyCode.Space)) {

			a += 0.3f;
			//Debug.Log (12345);
		}
		if (Input.GetKey (KeyCode.Y)) {

			a -= 0.3f;
			//Debug.Log (12345);
		}
		if (Input.GetKey (KeyCode.Z)) {

			c += 0.3f;
			//Debug.Log (12345);
		}
		if (Input.GetKey (KeyCode.X)) {

			c -= 0.3f;
			//Debug.Log (12345);
		}
		float time = Time.time;

		//float x = 5*Mathf.Sin(time);
		//float z = 5*Mathf.Cos(time);
		x = x + a;
		y = y + b;
		z = z + c;
		transform.position = new Vector3 (x,y,z);
	}
}
