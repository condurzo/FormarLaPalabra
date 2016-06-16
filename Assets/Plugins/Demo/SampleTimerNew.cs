using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class SampleTimerNew : MonoBehaviour {

	private DateTime simpleTimerEndTimestamp;
	private DateTime unbiasedTimerEndTimestamp;


	public string unbiasedFormatted;
	public Text TimerText;
	public Text VidasText;
	public Text VidasText2;
	public int Vidas;
	public int VidasTemp;
	public string UnbiandTemp;
	private TimeSpan unbiasedRemaining;

	void Awake(){
		unbiasedTimerEndTimestamp = this.ReadTimestamp("unbiasedTimer", UnbiasedTime.Instance.Now().AddSeconds(10));
		//PlayerPrefs.SetInt ("Vidas", 5);
		DontDestroyOnLoad(this); 

		if (FindObjectsOfType(GetType()).Length > 1){
			Destroy(gameObject);
		}

//		TimerText = GameObject.Find("TimerTex1False").GetComponent<Text>();
//		VidasText = GameObject.Find("VidasText1").GetComponent<Text>();
//		VidasText2 = GameObject.Find("VidasText2False").GetComponent<Text>();
	}


	void OnApplicationPause (bool paused) {
		if (paused) {
			this.WriteTimestamp("unbiasedTimer", unbiasedTimerEndTimestamp);
		}
		else {
			unbiasedTimerEndTimestamp = this.ReadTimestamp("unbiasedTimer", UnbiasedTime.Instance.Now().AddSeconds(60));
		}
	}

	void OnApplicationQuit () {
		this.WriteTimestamp("unbiasedTimer", unbiasedTimerEndTimestamp);
	}

	public void Resetear(){
		unbiasedTimerEndTimestamp = UnbiasedTime.Instance.Now().AddSeconds(10);
		this.WriteTimestamp("unbiasedTimer", unbiasedTimerEndTimestamp);
		Sumador();
	}

	public void Sumador(){
		unbiasedTimerEndTimestamp = unbiasedTimerEndTimestamp.AddSeconds(1800);
		this.WriteTimestamp("unbiasedTimer", unbiasedTimerEndTimestamp);
	}

	public void RestarVida(){
		if (Vidas > 0) {
			Vidas--;
			PlayerPrefs.SetInt ("Vidas", Vidas);
			switch (Vidas) {
			case 4:
				PlayerPrefs.SetInt ("LoseVida4", 0);
				break;
			case 3:
				PlayerPrefs.SetInt ("LoseVida3", 0);
				break;
			case 2:
				PlayerPrefs.SetInt ("LoseVida2", 0);
				break;
			case 1:
				PlayerPrefs.SetInt ("LoseVida1", 0);
				break;
			case 0:
				PlayerPrefs.SetInt ("LoseVida0", 0);
				break;
			}
		}
	}

	void ChekeadorVidas(){
		switch (Vidas) {
		case 4:
			PlayerPrefs.SetInt ("LoseVida4", 0);
			break;
		case 3 :
			PlayerPrefs.SetInt ("LoseVida3", 0);
			break;
		case 2:
			PlayerPrefs.SetInt ("LoseVida2", 0);
			break;
		case 1:
			PlayerPrefs.SetInt ("LoseVida1", 0);
			break;
		case 0:
			PlayerPrefs.SetInt ("LoseVida0", 0);
			break;
		}
	}

	void Update(){

		unbiasedRemaining = unbiasedTimerEndTimestamp - UnbiasedTime.Instance.Now();

		if (unbiasedRemaining.TotalSeconds > 0) {
			unbiasedFormatted = string.Format("{0}:{1:D2}:{2:D2}", unbiasedRemaining.Hours, unbiasedRemaining.Minutes, unbiasedRemaining.Seconds);
		}

		UnbiandTemp = unbiasedFormatted;
		Vidas = PlayerPrefs.GetInt ("Vidas");
		VidasText.text = Vidas.ToString();
		VidasText2.text = VidasText.text;
		TimerText.text = unbiasedFormatted;



		if (PlayerPrefs.GetInt ("LoseVida4") == 0) {
			if (Vidas == 4) {
				PlayerPrefs.SetInt ("EmpezarCon4", 1);
				PlayerPrefs.SetInt ("LoseVida4", 1);
			}
		}
		if (PlayerPrefs.GetInt ("LoseVida3") == 0) {
			if (Vidas == 3) {
				PlayerPrefs.SetInt ("EmpezarCon3", 1);
				PlayerPrefs.SetInt ("LoseVida3", 1);
			}
		}
		if (PlayerPrefs.GetInt ("LoseVida2") == 0) {
			if (Vidas == 2) {
				PlayerPrefs.SetInt ("EmpezarCon2", 1);
				PlayerPrefs.SetInt ("LoseVida2", 1);
			}
		}
		if (PlayerPrefs.GetInt ("LoseVida1") == 0) {
			if (Vidas == 1) {
				PlayerPrefs.SetInt ("EmpezarCon1", 1);
				PlayerPrefs.SetInt ("LoseVida1", 1);
			}
		}
		if (PlayerPrefs.GetInt ("LoseVida0") == 0) {
			if (Vidas == 0) {
				PlayerPrefs.SetInt ("EmpezarCon0", 1);
				PlayerPrefs.SetInt ("LoseVida0", 1);
			}
		}



		if (PlayerPrefs.GetInt ("EmpezarCon4") == 1) {
			if ((TimerText.text == "")||(TimerText.text == "0:00:00")) {
				Resetear ();
				Invoke ("VamosCon4", 2);
				PlayerPrefs.SetInt ("EmpezarCon4", 0);
			} else {
				Sumador();
				Invoke ("VamosCon4", 2);
				PlayerPrefs.SetInt ("EmpezarCon4", 0);
			}
		}

		if (PlayerPrefs.GetInt ("EmpezarCon3") == 1) {
			if ((TimerText.text == "")||(TimerText.text == "0:00:00")) {
				Resetear ();
				Invoke ("VamosCon3", 1);
				PlayerPrefs.SetInt ("EmpezarCon3", 0);
			} else {
				Sumador();
				Invoke ("VamosCon3", 1);
				PlayerPrefs.SetInt ("EmpezarCon3", 0);
			}
		}

		if (PlayerPrefs.GetInt ("EmpezarCon2") == 1) {
			if ((TimerText.text == "")||(TimerText.text == "0:00:00")) {
				Resetear ();
				Invoke ("VamosCon2", 1);
				PlayerPrefs.SetInt ("EmpezarCon2", 0);
			} else {
				Sumador();
				Invoke ("VamosCon2", 1);
				PlayerPrefs.SetInt ("EmpezarCon2", 0);
			}
		}

		if (PlayerPrefs.GetInt ("EmpezarCon1") == 1) {
			if ((TimerText.text == "")||(TimerText.text == "0:00:00")) {
				Resetear ();
				Invoke ("VamosCon1", 1);
				PlayerPrefs.SetInt ("EmpezarCon1", 0);
			} else {
				Sumador();
				Invoke ("VamosCon1", 1);
				PlayerPrefs.SetInt ("EmpezarCon1", 0);
			}
		}

		if (PlayerPrefs.GetInt ("EmpezarCon0") == 1) {
			if ((TimerText.text == "")||(TimerText.text == "0:00:00")) {
				Resetear ();
				Invoke ("VamosCon0", 1);
				PlayerPrefs.SetInt ("EmpezarCon0", 0);
			} else {
				Sumador();
				Invoke ("VamosCon0", 1);
				PlayerPrefs.SetInt ("EmpezarCon0", 0);
			}
		}

		//Vida 4
//		if ((unbiasedRemaining.TotalMinutes > 0)&&(unbiasedRemaining.TotalSeconds < 5)) {
//			Debug.Log ("LALALALA");
//		}
		if (PlayerPrefs.GetInt ("ChekearCon4") == 1) {
				if ((unbiasedRemaining.TotalMinutes < 0) && (unbiasedRemaining.TotalSeconds < 0)) {
					Debug.Log ("LALALALA 10");
					Vidas++;
					PlayerPrefs.SetInt ("Vidas", Vidas);
					PlayerPrefs.SetInt ("ChekearCon4", 0);
				}

		}

		if (PlayerPrefs.GetInt ("ChekearCon3") == 1) {
			if (unbiasedRemaining.TotalMinutes < 29)  {
				Debug.Log ("LALALALA 20");
				Vidas++;
				PlayerPrefs.SetInt ("Vidas", Vidas);
				PlayerPrefs.SetInt ("ChekearCon3", 0);
			}
		}

		if (PlayerPrefs.GetInt ("ChekearCon2") == 1) {
			if (unbiasedRemaining.TotalMinutes < 59) {
				Debug.Log ("LALALALA 30");
				Vidas++;
				PlayerPrefs.SetInt ("Vidas", Vidas);
				PlayerPrefs.SetInt ("ChekearCon2", 0);
			}
		}

		if (PlayerPrefs.GetInt ("ChekearCon1") == 1) {
			if (unbiasedRemaining.TotalMinutes < 89)  {
				Debug.Log ("LALALALA 40");
				Vidas++;
				PlayerPrefs.SetInt ("Vidas", Vidas);
				PlayerPrefs.SetInt ("ChekearCon1", 0);
			}
		}
		if (PlayerPrefs.GetInt ("ChekearCon0") == 1) {
			if ((unbiasedRemaining.Hours > 1 )&&(unbiasedRemaining.TotalMinutes < 19)) {
				Debug.Log ("LALALALA 50");
				Vidas++;
				PlayerPrefs.SetInt ("Vidas", Vidas);
				PlayerPrefs.SetInt ("ChekearCon0", 0);
			}
		}
	}


	void VamosCon4(){
		PlayerPrefs.SetInt ("ChekearCon4", 1);
	}
	void VamosCon3(){
		PlayerPrefs.SetInt ("ChekearCon3", 1);
	}
	void VamosCon2(){
		PlayerPrefs.SetInt ("ChekearCon2", 1);
	}
	void VamosCon1(){
		PlayerPrefs.SetInt ("ChekearCon1", 1);
	}
	void VamosCon0(){
		PlayerPrefs.SetInt ("ChekearCon0", 1);
	}
	private DateTime ReadTimestamp (string key, DateTime defaultValue) {
		long tmp = Convert.ToInt64(PlayerPrefs.GetString(key, "0"));
		if ( tmp == 0 ) {
			return defaultValue;
		}
		return DateTime.FromBinary(tmp);
	}

	private void WriteTimestamp (string key, DateTime time) {
		PlayerPrefs.SetString(key, time.ToBinary().ToString());
	}
}
