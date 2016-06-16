using UnityEngine;
using System.Collections;

public class Tutorial4Letras : MonoBehaviour {

	public GameObject RomboId01;
	public GameObject RomboId02;
	public GameObject RomboId03;
	public GameObject RomboId04;
//	public GameObject RomboId05;
//	public GameObject RomboId06;
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

		if (PlayerPrefs.GetInt ("levelTutorial") == 6) {
			PlayerPrefs.SetInt ("TutoJugable1", 2);
			PlayerPrefs.SetInt ("TutoJugable2", 1);
			CountdownTimer_CSHARP.TerminoPartida = false;
			Application.LoadLevel ("Tutotial-5Letras");
		} else {
			CountdownTimer_CSHARP.TerminoPartida = false;
			Application.LoadLevel ("Tutotial-4Letras");
		}
	}


	void ReloadLevel(){
		CountdownTimer_CSHARP.TerminoPartida = false;
		Application.LoadLevel("Tutotial-4Letras");
	}


	void Start () {
		System.GC.Collect();
		Level = PlayerPrefs.GetInt("levelTutorial");
		switch (Level){
		case 1 :

			Palabra = "Gato";
			RomboId01.GetComponent<Renderer>().material = LetraG;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraO;
			RomboId04.GetComponent<Renderer>().material = LetraT;
//			RomboId05.GetComponent<Renderer>().material = LetraA;
//			RomboId06.GetComponent<Renderer>().material = LetraB;
//			RomboId07.GetComponent<Renderer>().material = LetraG;
			break;

		case 2 :

			Palabra= "CASA";

			RomboId01.GetComponent<Renderer>().material = LetraC;
			RomboId02.GetComponent<Renderer>().material = LetraS;
			RomboId03.GetComponent<Renderer>().material = LetraA;
			RomboId04.GetComponent<Renderer>().material = LetraA;
//			RomboId05.GetComponent<Renderer>().material = LetraA;
//			RomboId06.GetComponent<Renderer>().material = LetraA;
//			RomboId07.GetComponent<Renderer>().material = LetraC;
			break;
		case 3 :
			Palabra = "VACA";

			RomboId01.GetComponent<Renderer>().material = LetraA;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraC;
			RomboId04.GetComponent<Renderer>().material = LetraV;
//			RomboId05.GetComponent<Renderer>().material = LetraE;
//			RomboId06.GetComponent<Renderer>().material = LetraL;
//			RomboId07.GetComponent<Renderer>().material = LetraL;
			break;
		case 4 :
			Palabra = "BOCA";

			RomboId01.GetComponent<Renderer>().material = LetraA;
			RomboId02.GetComponent<Renderer>().material = LetraC;
			RomboId03.GetComponent<Renderer>().material = LetraB;
			RomboId04.GetComponent<Renderer>().material = LetraO;
//			RomboId05.GetComponent<Renderer>().material = LetraN;
//			RomboId06.GetComponent<Renderer>().material = LetraA;
//			RomboId07.GetComponent<Renderer>().material = LetraT;
			break;
		case 5 :
			Palabra = "LUNA";
			RomboId01.GetComponent<Renderer>().material = LetraU;
			RomboId02.GetComponent<Renderer>().material = LetraL;
			RomboId03.GetComponent<Renderer>().material = LetraN;
			RomboId04.GetComponent<Renderer>().material = LetraA;
//			RomboId05.GetComponent<Renderer>().material = LetraE;
//			RomboId06.GetComponent<Renderer>().material = LetraL;
//			RomboId07.GetComponent<Renderer>().material = LetraL;
			break;
		
		}

	}	
}
