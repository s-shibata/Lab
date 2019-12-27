using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour {

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.velocity = new Vector3 (0, 0, 10.0f);
	}
	
	// Update is called once per frame
	void Update () {
		float time = Time.time;
		float x = 0.0f;
		float y = 5*Mathf.Sin(time);
    // zは今の自分の位置を代入
		transform.position = new Vector3 (x, y, transform.position.z);
		
	}
}
