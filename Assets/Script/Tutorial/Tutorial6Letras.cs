using UnityEngine;
using System.Collections;

public class Tutorial6Letras : MonoBehaviour {

	public GameObject RomboId01;
	public GameObject RomboId02;
	public GameObject RomboId03;
	public GameObject RomboId04;
	public GameObject RomboId05;
	public GameObject RomboId06;
	//	public GameObject RomboId07;
	//	public GameObject RomboId08;
	//	public GameObject RomboId09;
	//	public GameObject RomboId010;
	//	public GameObject RomboId011;
	//	public GameObject RomboId012;
	//	public GameObject RomboId013;
	//	public GameObject RomboId014;

	public Material LetraA;
	public Material LetraB;
	public Material LetraC;
	public Material LetraD;
	public Material LetraE;
	public Material LetraF;
	public Material LetraG;
	public Material LetraH;
	public Material LetraI;
	public Material LetraJ;
	public Material LetraK;
	public Material LetraL;
	public Material LetraM;
	public Material LetraN;
	public Material LetraO;
	public Material LetraP;
	public Material LetraQ;
	public Material LetraR;
	public Material LetraS;
	public Material LetraT;
	public Material LetraU;
	public Material LetraV;
	public Material LetraW;
	public Material LetraX;
	public Material LetraY;
	public Material LetraZ;

	public Material Letra;

	public int Level;

	public string Palabra;


	public int mostrador;

	void Avanzar(){

		if (PlayerPrefs.GetInt ("levelTutorial") == 16) {
			PlayerPrefs.SetInt ("TutoJugable3", 2);
			CountdownTimer_CSHARP.TerminoPartida = false;
			PlayerPrefs.SetInt ("TerminoTutoJugable", 1);
			Application.LoadLevel ("SelectorMundos");
		} else {
			CountdownTimer_CSHARP.TerminoPartida = false;
			Application.LoadLevel ("Tutotial-6Letras");
		}
	}


	void ReloadLevel(){
		CountdownTimer_CSHARP.TerminoPartida = false;
		Application.LoadLevel("Tutotial-6Letras");
	}


	void Start () {
		System.GC.Collect();
		Level = PlayerPrefs.GetInt("levelTutorial");
		switch (Level){
		case 11 :

			Palabra = "CABEZA";
			RomboId01.GetComponent<Renderer>().material = LetraC;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraB;
			RomboId04.GetComponent<Renderer>().material = LetraA;
			RomboId05.GetComponent<Renderer>().material = LetraZ;
			RomboId06.GetComponent<Renderer>().material = LetraE;
			//			RomboId07.GetComponent<Renderer>().material = LetraG;
			break;

		case 12 :

			Palabra= "MADERA";
			RomboId01.GetComponent<Renderer>().material = LetraE;
			RomboId02.GetComponent<Renderer>().material = LetraR;
			RomboId03.GetComponent<Renderer>().material = LetraA;
			RomboId04.GetComponent<Renderer>().material = LetraD;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraM;
			//			RomboId07.GetComponent<Renderer>().material = LetraC;
			break;
		case 13 :
			Palabra = "PELOTA";

			RomboId01.GetComponent<Renderer>().material = LetraT;
			RomboId02.GetComponent<Renderer>().material = LetraO;
			RomboId03.GetComponent<Renderer>().material = LetraL;
			RomboId04.GetComponent<Renderer>().material = LetraA;
			RomboId05.GetComponent<Renderer>().material = LetraP;
			RomboId06.GetComponent<Renderer>().material = LetraE;
			//			RomboId07.GetComponent<Renderer>().material = LetraL;
			break;
		case 14 :
			Palabra = "SENSOR";

			RomboId01.GetComponent<Renderer>().material = LetraE;
			RomboId02.GetComponent<Renderer>().material = LetraN;
			RomboId03.GetComponent<Renderer>().material = LetraS;
			RomboId04.GetComponent<Renderer>().material = LetraS;
			RomboId05.GetComponent<Renderer>().material = LetraO;
			RomboId06.GetComponent<Renderer>().material = LetraR;
			//			RomboId07.GetComponent<Renderer>().material = LetraT;
			break;
		case 15 :
			Palabra = "MENTIR";
			RomboId01.GetComponent<Renderer>().material = LetraM;
			RomboId02.GetComponent<Renderer>().material = LetraE;
			RomboId03.GetComponent<Renderer>().material = LetraI;
			RomboId04.GetComponent<Renderer>().material = LetraN;
			RomboId05.GetComponent<Renderer>().material = LetraT;
			RomboId06.GetComponent<Renderer>().material = LetraR;
			//			RomboId07.GetComponent<Renderer>().material = LetraL;
			break;

		}

	}	
}
