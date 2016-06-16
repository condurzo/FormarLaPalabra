using UnityEngine;
using System.Collections;

public class Tutorial5Letras : MonoBehaviour {

	public GameObject RomboId01;
	public GameObject RomboId02;
	public GameObject RomboId03;
	public GameObject RomboId04;
	public GameObject RomboId05;
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

		if (PlayerPrefs.GetInt ("levelTutorial") == 11) {
			PlayerPrefs.SetInt ("TutoJugable2", 2);
			PlayerPrefs.SetInt ("TutoJugable3", 1);
			CountdownTimer_CSHARP.TerminoPartida = false;
			Application.LoadLevel ("Tutotial-6Letras");
		} else {
			CountdownTimer_CSHARP.TerminoPartida = false;
			Application.LoadLevel ("Tutotial-5Letras");
		}
	}


	void ReloadLevel(){
		CountdownTimer_CSHARP.TerminoPartida = false;
		Application.LoadLevel("Tutotial-5Letras");
	}


	void Start () {
		System.GC.Collect();
		Level = PlayerPrefs.GetInt("levelTutorial");
		switch (Level){
		case 6 :

			Palabra = "PERRO";
			RomboId01.GetComponent<Renderer>().material = LetraR;
			RomboId02.GetComponent<Renderer>().material = LetraP;
			RomboId03.GetComponent<Renderer>().material = LetraO;
			RomboId04.GetComponent<Renderer>().material = LetraR;
			RomboId05.GetComponent<Renderer>().material = LetraE;
			//			RomboId06.GetComponent<Renderer>().material = LetraB;
			//			RomboId07.GetComponent<Renderer>().material = LetraG;
			break;

		case 7 :

			Palabra= "LAPIZ";

			RomboId01.GetComponent<Renderer>().material = LetraL;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraZ;
			RomboId04.GetComponent<Renderer>().material = LetraI;
			RomboId05.GetComponent<Renderer>().material = LetraP;
			//			RomboId06.GetComponent<Renderer>().material = LetraA;
			//			RomboId07.GetComponent<Renderer>().material = LetraC;
			break;
		case 8 :
			Palabra = "TABLA";

			RomboId01.GetComponent<Renderer>().material = LetraL;
			RomboId02.GetComponent<Renderer>().material = LetraB;
			RomboId03.GetComponent<Renderer>().material = LetraA;
			RomboId04.GetComponent<Renderer>().material = LetraT;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			//			RomboId06.GetComponent<Renderer>().material = LetraL;
			//			RomboId07.GetComponent<Renderer>().material = LetraL;
			break;
		case 9 :
			Palabra = "CABRA";

			RomboId01.GetComponent<Renderer>().material = LetraA;
			RomboId02.GetComponent<Renderer>().material = LetraR;
			RomboId03.GetComponent<Renderer>().material = LetraC;
			RomboId04.GetComponent<Renderer>().material = LetraB;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			//			RomboId06.GetComponent<Renderer>().material = LetraA;
			//			RomboId07.GetComponent<Renderer>().material = LetraT;
			break;
		case 10 :
			Palabra = "AVEJA";
			RomboId01.GetComponent<Renderer>().material = LetraJ;
			RomboId02.GetComponent<Renderer>().material = LetraE;
			RomboId03.GetComponent<Renderer>().material = LetraA;
			RomboId04.GetComponent<Renderer>().material = LetraV;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			//			RomboId06.GetComponent<Renderer>().material = LetraL;
			//			RomboId07.GetComponent<Renderer>().material = LetraL;
			break;

		}

	}	
}
