using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
[RequireComponent(typeof(AudioSource))]
public class text : MonoBehaviour{
	public new AudioSource audio;
	float[] waveData_ = new float[1024];
	public Text spokenText;
	private GUIStyle style;
	//public int score = 0;

	private DictationRecognizer dictationRecognizer;

	void Start(){
		audio = GetComponent<AudioSource>();
		
		//string a = "あ";
		dictationRecognizer = new DictationRecognizer();

		dictationRecognizer.DictationHypothesis += (text) =>
		{
			/*audio = GetComponent<AudioSource>();
			audio.clip = Microphone.Start (null, false, 50, 44100);
			while(Microphone.GetPosition(null)<=0){}
			audio.GetOutputData(waveData_, 1);
			var volume = waveData_.Select(y => y*y).Sum() / waveData_.Length;
			Debug.Log("1111");
			*/

			Debug.LogFormat("Dictation hypothesis: {0}", text);
			//style = new GUIStyle();
			//style.fontSize = 30;

			spokenText.text = text;
			//Rect rect = new Rect(10, 10, 400, 300);
			//GUI.Label(rect, spokenText.text, style);

			//transform.localScale = Vector3.one * volume*5;
			//GUI.TextField(new Rect(10, 10, 100, 100), text);

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
	}
	/*void OnGUI()
	{
		Rect rect = new Rect(10, 10, 400, 300);
		GUI.Label(rect, "Stand by Ready!", style);
	}*/
	void update(){
		//this.GetComponent<Text>().text = "点数";

	}
}
