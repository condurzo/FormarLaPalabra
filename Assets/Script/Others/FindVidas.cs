using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FindVidas : MonoBehaviour {

	public Text TimerTex1False;
	public Text VidasText1False;
	public Text VidasText2False;

	public Text TimerText;
	public Text VidasText;
	public Text VidasText2;


	void Awake(){
		TimerTex1False = GameObject.Find("TimerTex1False").GetComponent<Text>();
		VidasText1False = GameObject.Find("VidasText1False").GetComponent<Text>();
		VidasText2False = GameObject.Find("VidasText2False").GetComponent<Text>();
	}

	void Update(){
		TimerText.text = TimerTex1False.text;
		VidasText.text = VidasText1False.text;
		VidasText2.text = VidasText2False.text;
	}
}
