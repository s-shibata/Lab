using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Collections;

public class CubeGenerator : MonoBehaviour {	
	List<List<GameObject>> goList = new List<List<GameObject>>();
	//GameObject go1 = new GameObject ();
	//GameObject go2 = new GameObject ();

	Rigidbody rb;
	public GameObject CubePrefab;
	public GameObject Source;
	public GameObject Source1;
	void Start () {
		//rb = GetComponent<Rigidbody> ();
		//rb.velocity = new Vector3 (0, 0, 10.0f);
		Source = GameObject.Find("source");
		Source1 = GameObject.Find("source1");
		/*for (int i = 0; i < 30; i++) {
			List<GameObject> wao = new List<GameObject> ();
			for(int j = 0; j<30;j++){*/
		for (int i = 0; i < 60; i++) {
			List<GameObject> wao = new List<GameObject> ();
			for(int j = 0; j<60;j++){
				GameObject go = Instantiate (CubePrefab);
				wao.Add (go);
			}
			goList.Add (wao);
		}
	}
	void Update () {
		MoveToCircle ();
		//rb = GetComponent<Rigidbody> ();
		//rb.velocity = new Vector3 (0, 0, 10.0f);
	}
	void MoveToCircle(){
		//rb.velocity = new Vector3 (0, 0, 10.0f);
		int l = 0;
		for (int i = 0; i < 60; i++) {
		    int k = 0;
			for (int j = 0; j < 60; j++) {
		/*for (int i = 0; i < 30; i++) {
			int k = 0;
			for (int j = 0; j < 30; j++) {*/
				float time = Time.time;
				float dist = Vector3.Distance(Source.transform.position, goList[l][k].transform.position);
				float dist1 = Vector3.Distance(Source1.transform.position, goList[l][k].transform.position);
				float x = i;
				float y = Mathf.Sin(time-dist)+Mathf.Sin(time-dist1);
				float z = j;
				//goList[l][k].transform.position = new Vector3 (x, y, goList[l][k].transform.position.z);
				//goList[l][k].transform.position = new Vector3 (x, y, z);
				goList[l][k].transform.position = new Vector3 (x/2, y/2, z/2);
				k++;
			}
			l++;
		}
	}
}
