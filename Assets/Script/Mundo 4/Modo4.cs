using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Modo4 : MonoBehaviour {


	public GameObject RomboId01;
	public GameObject RomboId02;
	public GameObject RomboId03;
	public GameObject RomboId04;
	public GameObject RomboId05;
	public GameObject RomboId06;
	public GameObject RomboId07;
	public GameObject RomboId08;
	public GameObject RomboId09;
	public GameObject RomboId10;
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

	public int Vidas;

	public int mostrador;

	void Avanzar(){
		mostrador = PlayerPrefs.GetInt ("MostrarInterstitial");
		mostrador++;
		PlayerPrefs.SetInt ("MostrarInterstitial", mostrador);
		PlayerPrefs.SetInt ("PerdioPrimera",0);
		if (PlayerPrefs.GetInt ("level4") == 30) {
			PlayerPrefs.SetInt ("Stop-Nivel4-Ver1", 1);
			PlayerPrefs.SetInt ("Desblo-Nivel4-Ver1", 0);
			Modo1Puntos.Victoria = false;
			CountdownTimer_CSHARP.TerminoPartida = false;
			Application.LoadLevel ("SelectorMundos");
		} else {
			Modo1Puntos.Victoria = false;
			CountdownTimer_CSHARP.TerminoPartida = false;
			SceneManager.LoadScene ("Nivel4");
		}
	}
	void Atras(){
		mostrador = PlayerPrefs.GetInt ("MostrarInterstitial");
		mostrador++;
		PlayerPrefs.SetInt ("MostrarInterstitial", mostrador);
		PlayerPrefs.SetInt ("PerdioPrimera",0);
		if (PlayerPrefs.GetInt ("level4") == 30) {
			PlayerPrefs.SetInt ("Stop-Nivel4-Ver1", 1);
			PlayerPrefs.SetInt ("Desblo-Nivel4-Ver1", 0);
			Modo1Puntos.Victoria = false;
			CountdownTimer_CSHARP.TerminoPartida = false;
			Application.LoadLevel ("SelectorMundos");
		} else {
			Modo1Puntos.Victoria = false;
			CountdownTimer_CSHARP.TerminoPartida = false;
			SceneManager.LoadScene ("SelectorMundos");
		}
	}

	void AtrasLose(){
		Modo1Puntos.Victoria = false;
		CountdownTimer_CSHARP.TerminoPartida = false;

		Application.LoadLevel ("SelectorMundos");
	}

	void ReloadLevel(){
		Modo1Puntos.Victoria = false;
		CountdownTimer_CSHARP.TerminoPartida = false;
		if (Vidas > 0) {
			Application.LoadLevel ("Nivel4");
		} else {
			Application.LoadLevel ("SelectorMundos");
		}

	}

	void Start () {
		System.GC.Collect();
		Level = PlayerPrefs.GetInt("level4");
		switch (Level){
		case 1 :

			Palabra = "Presidente";
			RomboId01.GetComponent<Renderer>().material = LetraT;
			RomboId02.GetComponent<Renderer>().material = LetraN;
			RomboId03.GetComponent<Renderer>().material = LetraE;
			RomboId04.GetComponent<Renderer>().material = LetraE;
			RomboId05.GetComponent<Renderer>().material = LetraE;
			RomboId06.GetComponent<Renderer>().material = LetraS;
			RomboId07.GetComponent<Renderer>().material = LetraR;
			RomboId08.GetComponent<Renderer>().material = LetraD;
			RomboId09.GetComponent<Renderer>().material = LetraI;
			RomboId10.GetComponent<Renderer>().material = LetraP;
			break;

		case 2 :

			Palabra= "Murcielago";

			RomboId01.GetComponent<Renderer>().material = LetraC;
			RomboId02.GetComponent<Renderer>().material = LetraI;
			RomboId03.GetComponent<Renderer>().material = LetraE;
			RomboId04.GetComponent<Renderer>().material = LetraR;
			RomboId05.GetComponent<Renderer>().material = LetraM;
			RomboId06.GetComponent<Renderer>().material = LetraL;
			RomboId07.GetComponent<Renderer>().material = LetraO;
			RomboId08.GetComponent<Renderer>().material = LetraU;
			RomboId09.GetComponent<Renderer>().material = LetraA;
			RomboId10.GetComponent<Renderer>().material = LetraG;
			break;
		case 3 :
			Palabra = "Nacimiento";

			RomboId01.GetComponent<Renderer>().material = LetraO;
			RomboId02.GetComponent<Renderer>().material = LetraT;
			RomboId03.GetComponent<Renderer>().material = LetraN;
			RomboId04.GetComponent<Renderer>().material = LetraE;
			RomboId05.GetComponent<Renderer>().material = LetraN;
			RomboId06.GetComponent<Renderer>().material = LetraC;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			RomboId08.GetComponent<Renderer>().material = LetraI;
			RomboId09.GetComponent<Renderer>().material = LetraM;
			RomboId10.GetComponent<Renderer>().material = LetraI;
			break;
		case 4 :
			Palabra = "Crucigrama";

			RomboId01.GetComponent<Renderer>().material = LetraA;
			RomboId02.GetComponent<Renderer>().material = LetraC;
			RomboId03.GetComponent<Renderer>().material = LetraC;
			RomboId04.GetComponent<Renderer>().material = LetraM;
			RomboId05.GetComponent<Renderer>().material = LetraR;
			RomboId06.GetComponent<Renderer>().material = LetraU;
			RomboId07.GetComponent<Renderer>().material = LetraI;
			RomboId08.GetComponent<Renderer>().material = LetraA;
			RomboId09.GetComponent<Renderer>().material = LetraR;
			RomboId10.GetComponent<Renderer>().material = LetraG;
			break;
		case 5 :
			Palabra = "Melancolia";
			RomboId01.GetComponent<Renderer>().material = LetraM;
			RomboId02.GetComponent<Renderer>().material = LetraE;
			RomboId03.GetComponent<Renderer>().material = LetraL;
			RomboId04.GetComponent<Renderer>().material = LetraO;
			RomboId05.GetComponent<Renderer>().material = LetraC;
			RomboId06.GetComponent<Renderer>().material = LetraN;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			RomboId08.GetComponent<Renderer>().material = LetraL;
			RomboId09.GetComponent<Renderer>().material = LetraI;
			RomboId10.GetComponent<Renderer>().material = LetraA;
			break;
		case 6:
			Palabra = "Buscavidas";
			RomboId01.GetComponent<Renderer>().material = LetraC;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraV;
			RomboId04.GetComponent<Renderer>().material = LetraS;
			RomboId05.GetComponent<Renderer>().material = LetraU;
			RomboId06.GetComponent<Renderer>().material = LetraD;
			RomboId07.GetComponent<Renderer>().material = LetraI;
			RomboId08.GetComponent<Renderer>().material = LetraB;
			RomboId09.GetComponent<Renderer>().material = LetraA;
			RomboId10.GetComponent<Renderer>().material = LetraS;
			break;
		case 7 :
			Palabra = "Berberecho";
			RomboId01.GetComponent<Renderer>().material = LetraC;
			RomboId02.GetComponent<Renderer>().material = LetraH;
			RomboId03.GetComponent<Renderer>().material = LetraO;
			RomboId04.GetComponent<Renderer>().material = LetraR;
			RomboId05.GetComponent<Renderer>().material = LetraE;
			RomboId06.GetComponent<Renderer>().material = LetraB;
			RomboId07.GetComponent<Renderer>().material = LetraE;
			RomboId08.GetComponent<Renderer>().material = LetraE;
			RomboId09.GetComponent<Renderer>().material = LetraB;
			RomboId10.GetComponent<Renderer>().material = LetraR;
			break;
		case 8 :
			Palabra = "Maquillaje";
			RomboId01.GetComponent<Renderer>().material = LetraJ;
			RomboId02.GetComponent<Renderer>().material = LetraM;
			RomboId03.GetComponent<Renderer>().material = LetraA;
			RomboId04.GetComponent<Renderer>().material = LetraA;
			RomboId05.GetComponent<Renderer>().material = LetraE;
			RomboId06.GetComponent<Renderer>().material = LetraI;
			RomboId07.GetComponent<Renderer>().material = LetraQ;
			RomboId08.GetComponent<Renderer>().material = LetraL;
			RomboId09.GetComponent<Renderer>().material = LetraL;
			RomboId10.GetComponent<Renderer>().material = LetraU;
			break;
		case 9 :
			Palabra = "Manzanilla";
			RomboId01.GetComponent<Renderer>().material = LetraM;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraN;
			RomboId04.GetComponent<Renderer>().material = LetraL;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraA;
			RomboId07.GetComponent<Renderer>().material = LetraZ;
			RomboId08.GetComponent<Renderer>().material = LetraL;
			RomboId09.GetComponent<Renderer>().material = LetraI;
			RomboId10.GetComponent<Renderer>().material = LetraN;
			break;
		case 10 :
			Palabra = "Justiciero";
			RomboId01.GetComponent<Renderer>().material = LetraS;
			RomboId02.GetComponent<Renderer>().material = LetraU;
			RomboId03.GetComponent<Renderer>().material = LetraR;
			RomboId04.GetComponent<Renderer>().material = LetraT;
			RomboId05.GetComponent<Renderer>().material = LetraJ;
			RomboId06.GetComponent<Renderer>().material = LetraO;
			RomboId07.GetComponent<Renderer>().material = LetraE;
			RomboId08.GetComponent<Renderer>().material = LetraI;
			RomboId09.GetComponent<Renderer>().material = LetraC;
			RomboId10.GetComponent<Renderer>().material = LetraI;
			break;
		case 11 :

			Palabra = "Golondrina";
			RomboId01.GetComponent<Renderer>().material = LetraO;
			RomboId02.GetComponent<Renderer>().material = LetraO;
			RomboId03.GetComponent<Renderer>().material = LetraG;
			RomboId04.GetComponent<Renderer>().material = LetraN;
			RomboId05.GetComponent<Renderer>().material = LetraL;
			RomboId06.GetComponent<Renderer>().material = LetraA;
			RomboId07.GetComponent<Renderer>().material = LetraN;
			RomboId08.GetComponent<Renderer>().material = LetraD;
			RomboId09.GetComponent<Renderer>().material = LetraR;
			RomboId10.GetComponent<Renderer>().material = LetraI;
			break;

		case 12 :
			Palabra = "Metropolis";
			RomboId01.GetComponent<Renderer>().material = LetraS;
			RomboId02.GetComponent<Renderer>().material = LetraI;
			RomboId03.GetComponent<Renderer>().material = LetraL;
			RomboId04.GetComponent<Renderer>().material = LetraT;
			RomboId05.GetComponent<Renderer>().material = LetraE;
			RomboId06.GetComponent<Renderer>().material = LetraM;
			RomboId07.GetComponent<Renderer>().material = LetraO;
			RomboId08.GetComponent<Renderer>().material = LetraR;
			RomboId09.GetComponent<Renderer>().material = LetraO;
			RomboId10.GetComponent<Renderer>().material = LetraP;
			break;
		case 13 :
			Palabra = "Dinosaurio";
			RomboId01.GetComponent<Renderer>().material = LetraR;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraO;
			RomboId04.GetComponent<Renderer>().material = LetraI;
			RomboId05.GetComponent<Renderer>().material = LetraU;
			RomboId06.GetComponent<Renderer>().material = LetraS;
			RomboId07.GetComponent<Renderer>().material = LetraN;
			RomboId08.GetComponent<Renderer>().material = LetraO;
			RomboId09.GetComponent<Renderer>().material = LetraD;
			RomboId10.GetComponent<Renderer>().material = LetraI;
			break;
		case 14 :
			Palabra = "Geografico";
			RomboId01.GetComponent<Renderer>().material = LetraR;
			RomboId02.GetComponent<Renderer>().material = LetraG;
			RomboId03.GetComponent<Renderer>().material = LetraE;
			RomboId04.GetComponent<Renderer>().material = LetraA;
			RomboId05.GetComponent<Renderer>().material = LetraG;
			RomboId06.GetComponent<Renderer>().material = LetraO;
			RomboId07.GetComponent<Renderer>().material = LetraO;
			RomboId08.GetComponent<Renderer>().material = LetraF;
			RomboId09.GetComponent<Renderer>().material = LetraI;
			RomboId10.GetComponent<Renderer>().material = LetraC;
			break;
		case 15 :
			Palabra = "Prismatico";
			RomboId01.GetComponent<Renderer>().material = LetraM;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraT;
			RomboId04.GetComponent<Renderer>().material = LetraS;
			RomboId05.GetComponent<Renderer>().material = LetraR;
			RomboId06.GetComponent<Renderer>().material = LetraI;
			RomboId07.GetComponent<Renderer>().material = LetraC;
			RomboId08.GetComponent<Renderer>().material = LetraI;
			RomboId09.GetComponent<Renderer>().material = LetraP;
			RomboId10.GetComponent<Renderer>().material = LetraO;
			break;
		case 16:
			Palabra = "Corazonada";
			RomboId01.GetComponent<Renderer>().material = LetraO;
			RomboId02.GetComponent<Renderer>().material = LetraZ;
			RomboId03.GetComponent<Renderer>().material = LetraA;
			RomboId04.GetComponent<Renderer>().material = LetraA;
			RomboId05.GetComponent<Renderer>().material = LetraN;
			RomboId06.GetComponent<Renderer>().material = LetraC;
			RomboId07.GetComponent<Renderer>().material = LetraR;
			RomboId08.GetComponent<Renderer>().material = LetraD;
			RomboId09.GetComponent<Renderer>().material = LetraA;
			RomboId10.GetComponent<Renderer>().material = LetraO;
			break;
		case 17 :
			Palabra = "Entuciasmo";
			RomboId01.GetComponent<Renderer>().material = LetraU;
			RomboId02.GetComponent<Renderer>().material = LetraC;
			RomboId03.GetComponent<Renderer>().material = LetraI;
			RomboId04.GetComponent<Renderer>().material = LetraT;
			RomboId05.GetComponent<Renderer>().material = LetraO;
			RomboId06.GetComponent<Renderer>().material = LetraM;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			RomboId08.GetComponent<Renderer>().material = LetraN;
			RomboId09.GetComponent<Renderer>().material = LetraE;
			RomboId10.GetComponent<Renderer>().material = LetraS;
			break;
		case 18 :
			Palabra = "Galardonar";
			RomboId01.GetComponent<Renderer>().material = LetraG;
			RomboId02.GetComponent<Renderer>().material = LetraL;
			RomboId03.GetComponent<Renderer>().material = LetraR;
			RomboId04.GetComponent<Renderer>().material = LetraR;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraA;
			RomboId07.GetComponent<Renderer>().material = LetraD;
			RomboId08.GetComponent<Renderer>().material = LetraA;
			RomboId09.GetComponent<Renderer>().material = LetraN;
			RomboId10.GetComponent<Renderer>().material = LetraO;
			break;
		case 19 :
			Palabra = "Fecundidad";
			RomboId01.GetComponent<Renderer>().material = LetraD;
			RomboId02.GetComponent<Renderer>().material = LetraN;
			RomboId03.GetComponent<Renderer>().material = LetraU;
			RomboId04.GetComponent<Renderer>().material = LetraI;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraD;
			RomboId07.GetComponent<Renderer>().material = LetraC;
			RomboId08.GetComponent<Renderer>().material = LetraD;
			RomboId09.GetComponent<Renderer>().material = LetraF;
			RomboId10.GetComponent<Renderer>().material = LetraE;
			break;
		case 20 :
			Palabra = "Respuestas";
			RomboId01.GetComponent<Renderer>().material = LetraS;
			RomboId02.GetComponent<Renderer>().material = LetraU;
			RomboId03.GetComponent<Renderer>().material = LetraP;
			RomboId04.GetComponent<Renderer>().material = LetraA;
			RomboId05.GetComponent<Renderer>().material = LetraE;
			RomboId06.GetComponent<Renderer>().material = LetraE;
			RomboId07.GetComponent<Renderer>().material = LetraS;
			RomboId08.GetComponent<Renderer>().material = LetraT;
			RomboId09.GetComponent<Renderer>().material = LetraS;
			RomboId10.GetComponent<Renderer>().material = LetraR;
			break;
		case 21 :

			Palabra = "Comentario";
			RomboId01.GetComponent<Renderer>().material = LetraC;
			RomboId02.GetComponent<Renderer>().material = LetraO;
			RomboId03.GetComponent<Renderer>().material = LetraO;
			RomboId04.GetComponent<Renderer>().material = LetraE;
			RomboId05.GetComponent<Renderer>().material = LetraM;
			RomboId06.GetComponent<Renderer>().material = LetraA;
			RomboId07.GetComponent<Renderer>().material = LetraI;
			RomboId08.GetComponent<Renderer>().material = LetraN;
			RomboId09.GetComponent<Renderer>().material = LetraT;
			RomboId10.GetComponent<Renderer>().material = LetraR;
			break;

		case 22 :
			Palabra = "Privacidad";
			RomboId01.GetComponent<Renderer>().material = LetraD;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraD;
			RomboId04.GetComponent<Renderer>().material = LetraI;
			RomboId05.GetComponent<Renderer>().material = LetraP;
			RomboId06.GetComponent<Renderer>().material = LetraR;
			RomboId07.GetComponent<Renderer>().material = LetraI;
			RomboId08.GetComponent<Renderer>().material = LetraC;
			RomboId09.GetComponent<Renderer>().material = LetraA;
			RomboId10.GetComponent<Renderer>().material = LetraV;
			break;
		case 23 :
			Palabra = "Ortografia";
			RomboId01.GetComponent<Renderer>().material = LetraO;
			RomboId02.GetComponent<Renderer>().material = LetraT;
			RomboId03.GetComponent<Renderer>().material = LetraG;
			RomboId04.GetComponent<Renderer>().material = LetraA;
			RomboId05.GetComponent<Renderer>().material = LetraR;
			RomboId06.GetComponent<Renderer>().material = LetraO;
			RomboId07.GetComponent<Renderer>().material = LetraR;
			RomboId08.GetComponent<Renderer>().material = LetraI;
			RomboId09.GetComponent<Renderer>().material = LetraF;
			RomboId10.GetComponent<Renderer>().material = LetraA;
			break;
		case 24 :
			Palabra = "Comediante";
			RomboId01.GetComponent<Renderer>().material = LetraI;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraN;
			RomboId04.GetComponent<Renderer>().material = LetraD;
			RomboId05.GetComponent<Renderer>().material = LetraC;
			RomboId06.GetComponent<Renderer>().material = LetraO;
			RomboId07.GetComponent<Renderer>().material = LetraT;
			RomboId08.GetComponent<Renderer>().material = LetraE;
			RomboId09.GetComponent<Renderer>().material = LetraM;
			RomboId10.GetComponent<Renderer>().material = LetraE;
			break;
		case 25 :
			Palabra = "Brigadista";
			RomboId01.GetComponent<Renderer>().material = LetraD;
			RomboId02.GetComponent<Renderer>().material = LetraG;
			RomboId03.GetComponent<Renderer>().material = LetraR;
			RomboId04.GetComponent<Renderer>().material = LetraI;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraI;
			RomboId07.GetComponent<Renderer>().material = LetraB;
			RomboId08.GetComponent<Renderer>().material = LetraS;
			RomboId09.GetComponent<Renderer>().material = LetraT;
			RomboId10.GetComponent<Renderer>().material = LetraA;
			break;
		case 26:
			Palabra = "Hipopotamo";
			RomboId01.GetComponent<Renderer>().material = LetraP;
			RomboId02.GetComponent<Renderer>().material = LetraO;
			RomboId03.GetComponent<Renderer>().material = LetraP;
			RomboId04.GetComponent<Renderer>().material = LetraO;
			RomboId05.GetComponent<Renderer>().material = LetraT;
			RomboId06.GetComponent<Renderer>().material = LetraA;
			RomboId07.GetComponent<Renderer>().material = LetraI;
			RomboId08.GetComponent<Renderer>().material = LetraO;
			RomboId09.GetComponent<Renderer>().material = LetraM;
			RomboId10.GetComponent<Renderer>().material = LetraH;
			break;
		case 27 :
			Palabra = "Destapador";
			RomboId01.GetComponent<Renderer>().material = LetraA;
			RomboId02.GetComponent<Renderer>().material = LetraP;
			RomboId03.GetComponent<Renderer>().material = LetraA;
			RomboId04.GetComponent<Renderer>().material = LetraT;
			RomboId05.GetComponent<Renderer>().material = LetraS;
			RomboId06.GetComponent<Renderer>().material = LetraD;
			RomboId07.GetComponent<Renderer>().material = LetraO;
			RomboId08.GetComponent<Renderer>().material = LetraD;
			RomboId09.GetComponent<Renderer>().material = LetraE;
			RomboId10.GetComponent<Renderer>().material = LetraR;
			break;
		case 28 :
			Palabra = "Sacacorcho";
			RomboId01.GetComponent<Renderer>().material = LetraC;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraC;
			RomboId04.GetComponent<Renderer>().material = LetraA;
			RomboId05.GetComponent<Renderer>().material = LetraO;
			RomboId06.GetComponent<Renderer>().material = LetraH;
			RomboId07.GetComponent<Renderer>().material = LetraO;
			RomboId08.GetComponent<Renderer>().material = LetraS;
			RomboId09.GetComponent<Renderer>().material = LetraC;
			RomboId10.GetComponent<Renderer>().material = LetraR;
			break;
		case 29 :
			Palabra = "Ventilador";
			RomboId01.GetComponent<Renderer>().material = LetraT;
			RomboId02.GetComponent<Renderer>().material = LetraI;
			RomboId03.GetComponent<Renderer>().material = LetraL;
			RomboId04.GetComponent<Renderer>().material = LetraN;
			RomboId05.GetComponent<Renderer>().material = LetraE;
			RomboId06.GetComponent<Renderer>().material = LetraV;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			RomboId08.GetComponent<Renderer>().material = LetraR;
			RomboId09.GetComponent<Renderer>().material = LetraO;
			RomboId10.GetComponent<Renderer>().material = LetraD;
			break;
		case 30 :
			Palabra = "Aurricular";
			RomboId01.GetComponent<Renderer>().material = LetraU;
			RomboId02.GetComponent<Renderer>().material = LetraI;
			RomboId03.GetComponent<Renderer>().material = LetraR;
			RomboId04.GetComponent<Renderer>().material = LetraL;
			RomboId05.GetComponent<Renderer>().material = LetraC;
			RomboId06.GetComponent<Renderer>().material = LetraU;
			RomboId07.GetComponent<Renderer>().material = LetraR;
			RomboId08.GetComponent<Renderer>().material = LetraA;
			RomboId09.GetComponent<Renderer>().material = LetraR;
			RomboId10.GetComponent<Renderer>().material = LetraA;
			break;
		}


	}

	void Update(){
		Vidas = PlayerPrefs.GetInt ("Vidas");
	}

}
