using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ManagerTutorial : MonoBehaviour {

	public GameObject Pelotita1;
	public GameObject Pelotita2;
	public GameObject Pelotita3;
	public GameObject FlechaDer;
	public GameObject FlechaIzq;
	public GameObject FlechaFinal;
	public static int numPantalla;
	public admobscript ads;
	public bool tiempo;



	void Start(){
		System.GC.Collect();
		ads.HideBanner();
	}

	public void Saltar(){
		PlayerPrefs.SetInt ("Tutorial",1);
		PlayerPrefs.SetInt ("TutoJugable1", 1);
		Application.LoadLevel ("Tutotial-4Letras");
	}
	void Agrando(){
		FlechaDer.transform.localScale = new Vector3(1f, 1f, 1f);
		FlechaIzq.transform.localScale = new Vector3(1f, 1f, 1f);
		FlechaFinal.transform.localScale = new Vector3(1f, 1f, 1f);
		tiempo = false;
	}
	void Achico(){
		FlechaDer.transform.localScale = new Vector3(0.85f, 0.85f, 0.85f);
		FlechaIzq.transform.localScale = new Vector3(0.85f, 0.85f, 0.85f);
		FlechaFinal.transform.localScale = new Vector3(0.85f, 0.85f, 0.85f);
		tiempo = true;
	}

	void Update () {
		if (!tiempo) {
			Invoke ("Achico", 0.4f);
		} else {
			Invoke ("Agrando", 0.4f);
		}


		switch (numPantalla) {
		case 0:
			Pelotita1.GetComponent<Image> ().color = Color.white;
			Pelotita2.GetComponent<Image> ().color = Color.grey;
			Pelotita3.GetComponent<Image> ().color = Color.grey;
			FlechaDer.SetActive (true);
			FlechaIzq.SetActive (false);
			FlechaFinal.SetActive (false);
			break;
		case 1:
			Pelotita1.GetComponent<Image> ().color = Color.grey;
			Pelotita2.GetComponent<Image> ().color = Color.white;
			Pelotita3.GetComponent<Image> ().color = Color.grey;
			FlechaDer.SetActive (true);
			FlechaIzq.SetActive (true);
			FlechaFinal.SetActive (false);
			break;
		case 2:
			Pelotita1.GetComponent<Image> ().color = Color.grey;
			Pelotita2.GetComponent<Image> ().color = Color.grey;
			Pelotita3.GetComponent<Image> ().color = Color.white;
			FlechaDer.SetActive (false);
			FlechaIzq.SetActive (true);
			FlechaFinal.SetActive (true);
			break;
		}
	}
}
