using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour {

	public GameObject backMenu;
	public float segundosPasados;

	public int Vidas;

	public SampleTimerNew timercito;

	void Update () {
		Vidas = PlayerPrefs.GetInt ("Vidas");

		segundosPasados += Time.deltaTime;

		if (!CountdownTimer_CSHARP.TerminoPartida){
			if (Input.GetKeyDown (KeyCode.Escape)) {
				backMenu.SetActive (true);
			}	
		}
	}

	void GoToMenu(){
		if (segundosPasados >= 20) {
			if (Vidas > 0) {
				Vidas--;
				PlayerPrefs.SetInt ("Vidas", Vidas);
				Debug.Log ("VIDAS: " + PlayerPrefs.GetInt ("Vidas"));
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
			PlayerPrefs.SetInt ("PerdioPrimera",1);
			segundosPasados = 0;
		}
		Application.LoadLevel ("SelectorMundos");
	}
	void CancelBtn(){
		backMenu.SetActive (false);
	}
}
