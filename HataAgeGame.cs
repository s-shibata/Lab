using System;
using System.Text;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class HataAgeGame : MonoBehaviour
{
	//public static GameObject FindWithTag ();
	//音声コマンドのキーワード
	private string[] m_Keywords = { "あ", "い", "う", "え" };

	private KeywordRecognizer m_Recognizer;

	//右手の位置ターゲット
	public GameObject RighSphre;
	//左手の位置ターゲット
	public GameObject LeftSphre;

	//右手と左手の上下それぞれの座標
	private Vector3 RightHandUpPos = new Vector3(-0.51f, 2.159f, 0f);
	private Vector3 LeftHandUpPos = new Vector3(0.588f, 2.108f, 0f);
	private Vector3 RightHandDownPos = new Vector3(-0.3f, 0.838f, 0f);
	private Vector3 LeftHandDownPos = new Vector3(0.341f, 0.838f, 0f);

	void Start()
	{
		//LeftSphre = GameObject.FindWithTag("LeftSphre");
		//RighSphre = GameObject.FindWithTag("RighSphre");
		m_Recognizer = new KeywordRecognizer(m_Keywords);
		m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
		m_Recognizer.Start();
	}

	private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
	{
		//ログ出力
		StringBuilder builder = new StringBuilder();
		builder.AppendFormat("{0} ({1}){2}", args.text, args.confidence, Environment.NewLine);
		builder.AppendFormat("\tTimestamp: {0}{1}", args.phraseStartTime, Environment.NewLine);
		builder.AppendFormat("\tDuration: {0} seconds{1}", args.phraseDuration.TotalSeconds, Environment.NewLine);
		Debug.Log(builder.ToString());

		//認識したキーワードで処理判定
		switch (args.text)
		{
		case "あ":
			AkaAgete();
			break;
		case "い":
			ShiroAgete();
			break;
		case "う":
			AkaSagete();
			break;
		case "え":
			ShiroSagete();
			break;
		}
	}

	private void AkaAgete()
	{
		RighSphre.transform.position = RightHandUpPos;
	}
	private void ShiroAgete()
	{
		LeftSphre.transform.position = LeftHandUpPos;
	}

	private void AkaSagete()
	{
		RighSphre.transform.position = RightHandDownPos;
	}

	private void ShiroSagete()
	{
		LeftSphre.transform.position = LeftHandDownPos;
	}

}
