using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;

public class shooting : MonoBehaviour {
	GameObject shoot;
	public int j;
	public dictation DICTATION;
	public GameObject shellPrefab;
	public float shotSpeed;
	//public string kana;
	//public AudioClip shotSound;
	void Start(){
		shoot = GameObject.Find ("Text");
	}

	void Update () {
		//dictation fre = shoot.GetComponent<dictation>();
		//int i = DICTATION.j;
		//Debug.Log(i);
		
		//float volume = fre.volume;
		//Debug.Log (shoot.vol);
		//kana = shoot.spokenText.text;
		//Debug.Log ("111");



		// もしも「Fire1」というボタンが押されたら（条件）
		//if (kana == kana_block) {
			// ①Shotという名前の関数（命令ブロック）を実行する。
		//int n = 0;
		if (Input.GetKey (KeyCode.W)) {
			Shot ();
			//n++;
		}
		//if (n == 5) {
		//	
		//	n = 0;
		//}
			// ②効果音を再生する。
			//AudioSource.PlayClipAtPoint(shotSound, transform.position);
	}


	public void Shot(){

		// プレファブから砲弾(Shell)オブジェクトを作成し、それをshellという名前の箱に入れる。
		GameObject shell =  (GameObject)Instantiate(shellPrefab, transform.position, Quaternion.identity);

		// Rigidbodyの情報を取得し、それをshellRigidbodyという名前の箱に入れる。
		Rigidbody shellRigidbody = shell.GetComponent<Rigidbody>();
		//this.GetComponent<Rigidbody>().AddForce(transform.forward+transform.right)*shSpeed,ForceMode.VelocityChange);
		// shellRigidbodyにz軸方向の力を加える。
		shellRigidbody.AddForce(transform.forward * shotSpeed);

	}
}
