using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour {

	public GameObject backMenu;
	public float segundosPasados;

	void Update () {
		segundosPasados += Time.deltaTime;

		if (!CountdownTimer_CSHARP.TerminoPartida){
			if (Input.GetKeyDown (KeyCode.Escape)) {
				backMenu.SetActive (true);
			}	
		}
	}

	void GoToMenu(){
		if (segundosPasados >= 20) {
			PlayerPrefs.SetInt ("PerdioPrimera",1);
			segundosPasados = 0;
		}
		Application.LoadLevel ("SelectorMundos");
	}
	void CancelBtn(){
		backMenu.SetActive (false);
	}
}
