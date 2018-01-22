using System.Collections;
using System.Text;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
[RequireComponent(typeof(AudioSource))]
public class dictation : MonoBehaviour{
	System.Globalization.CompareInfo ci =
		System.Globalization.CultureInfo.CurrentCulture.CompareInfo;
	public new AudioSource audio;
	float[] waveData_ = new float[1024];
	public string tango;
	public Text spokenText;
	private GUIStyle style;
	public int i;
	public string kana_block = "あ";

	//public int score = 0;
	public int j;
	private DictationRecognizer dictationRecognizer;

	void Start(){
		//audio = GetComponent<AudioSource>();
		audio = GetComponent<AudioSource>();
		audio.clip = Microphone.Start (null, false, 50, 44100);
		while(Microphone.GetPosition(null)<=0){}
		audio.Play();
		
		//string a = "あ";
		dictationRecognizer = new DictationRecognizer();
			
		dictationRecognizer.DictationHypothesis += (text) =>
		{
			//i = 0;
			//var volume = waveData_.Select(y => y*y).Sum() / waveData_.Length;

			
			//Debug.Log(volume);
			audio.GetOutputData(waveData_, 1);
			var volume = waveData_.Select(y => y*y).Sum() / waveData_.Length;
			//vol = (float)volume;
			//float Vo = volume;
			//Debug.Log(volume);
			//transform.localScale = Vector3.one * volume*5;
			//Debug.LogFormat("Dictation hypothesis: {0}", text);
			//vol = 1000;
			//style = new GUIStyle();
			//style.fontSize = 30;

			spokenText.text = (string)text;
			//m_Recognitions.text += text + "\n";
			//i = volume*10000;
			//spokenText.fontSize = (int)i;
			spokenText.fontSize = 29;

			//Debug.Log(i);
			//if(spokenText.text == kana_block){

			Debug.Log(spokenText.text);

			//}*/

			/*if (i == kana_block) {
				Debug.Log ("qweqwe");

			}*/
			//string str = "今日はいい天気です。";

			//strに「天気」が含まれているか調べる
			if (0 <= spokenText.text.IndexOf("こんにちは"))
			{
				i  = 1;
				Debug.Log("yes");
			}
			else if (0 <= spokenText.text.IndexOf("ありがとう"))
			{
				i  = 1;
				Debug.Log("yes");
			}
			else if (0 <= spokenText.text.IndexOf("こんばんわ"))
			{
				i = 1;
				Debug.Log("yes");
			}
			else
			{
				Debug.Log("no");
			}

			//transform.localScale = Vector3.one * volume*5;
			//GUI.TextField(new Rect(10, 10, 100, 100), text);
			Debug.Log(i);
			//Debug.Log(text);
		};
		

		dictationRecognizer.DictationComplete += (completionCause) =>
		{
			if (completionCause != DictationCompletionCause.Complete)
				Debug.Log("2222");
				Debug.LogErrorFormat("Dictation completed unsuccessfully: {0}.", completionCause);
		};

		dictationRecognizer.DictationError += (error, hresult) =>
		{
			Debug.Log("3333");
			Debug.LogErrorFormat("Dictation error: {0}; HResult = {1}.", error, hresult);
		};
		dictationRecognizer.Start();
		/*if (ci.Compare (i , kana_block, System.Globalization.CompareOptions.IgnoreWidth |
			System.Globalization.CompareOptions.IgnoreKanaType) == 0) {
			Debug.Log ("123123");
		} else {
			Debug.Log ("987987");
		}*/


	}
	public int GetBullet(){
		return i;
	}
	void update(){
		
		/*if (ci.Compare (i , kana_block, System.Globalization.CompareOptions.IgnoreWidth |
			System.Globalization.CompareOptions.IgnoreKanaType) == 0) {
			Debug.Log ("123123");
		} else {
			Debug.Log ("987987");
		}*/
		
		//this.GetComponent<Text>().text = "点数";

	}
}
