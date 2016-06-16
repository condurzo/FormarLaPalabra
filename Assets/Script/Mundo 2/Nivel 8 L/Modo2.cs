using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Modo2 : MonoBehaviour {


	public GameObject RomboId01;
	public GameObject RomboId02;
	public GameObject RomboId03;
	public GameObject RomboId04;
	public GameObject RomboId05;
	public GameObject RomboId06;
	public GameObject RomboId07;
	public GameObject RomboId08;
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

	public int Vidas;

	public int mostrador;

	void Avanzar(){
		mostrador = PlayerPrefs.GetInt ("MostrarInterstitial");
		mostrador++;
		PlayerPrefs.SetInt ("MostrarInterstitial", mostrador);
		PlayerPrefs.SetInt ("PerdioPrimera",0);
		if (PlayerPrefs.GetInt ("level2") == 30) {
			PlayerPrefs.SetInt ("Desblo-Nivel3-Ver1", 1);
			PlayerPrefs.SetInt ("Stop-Nivel2-Ver1", 1);
			PlayerPrefs.SetInt ("Desblo-Nivel2-Ver1", 0);
			Modo1Puntos.Victoria = false;
			CountdownTimer_CSHARP.TerminoPartida = false;
			Application.LoadLevel ("SelectorMundos");
		} else {
			Modo1Puntos.Victoria = false;
			CountdownTimer_CSHARP.TerminoPartida = false;
			SceneManager.LoadScene ("Nivel2");
		}
	}
	void Atras(){
		mostrador = PlayerPrefs.GetInt ("MostrarInterstitial");
		mostrador++;
		PlayerPrefs.SetInt ("MostrarInterstitial", mostrador);
		PlayerPrefs.SetInt ("PerdioPrimera",0);
		if (PlayerPrefs.GetInt ("level2") == 30) {
			PlayerPrefs.SetInt ("Desblo-Nivel3-Ver1", 1);
			PlayerPrefs.SetInt ("Stop-Nivel2-Ver1", 1);
			PlayerPrefs.SetInt ("Desblo-Nivel2-Ver1", 0);
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
			Application.LoadLevel("Nivel2");
		} else {
			Application.LoadLevel ("SelectorMundos");
		}

	}

	void Start () {
		System.GC.Collect();
		Level = PlayerPrefs.GetInt("level2");
		switch (Level){
		case 1 :

			Palabra = "Parecido";
			RomboId01.GetComponent<Renderer>().material = LetraR;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraP;
			RomboId04.GetComponent<Renderer>().material = LetraE;
			RomboId05.GetComponent<Renderer>().material = LetraC;
			RomboId06.GetComponent<Renderer>().material = LetraO;
			RomboId07.GetComponent<Renderer>().material = LetraD;
			RomboId08.GetComponent<Renderer>().material = LetraI;
			break;

		case 2 :

			Palabra= "Misterio";

			RomboId01.GetComponent<Renderer>().material = LetraT;
			RomboId02.GetComponent<Renderer>().material = LetraS;
			RomboId03.GetComponent<Renderer>().material = LetraI;
			RomboId04.GetComponent<Renderer>().material = LetraE;
			RomboId05.GetComponent<Renderer>().material = LetraM;
			RomboId06.GetComponent<Renderer>().material = LetraR;
			RomboId07.GetComponent<Renderer>().material = LetraI;
			RomboId08.GetComponent<Renderer>().material = LetraO;
			break;
		case 3 :
			Palabra = "Libertad";

			RomboId01.GetComponent<Renderer>().material = LetraD;
			RomboId02.GetComponent<Renderer>().material = LetraL;
			RomboId03.GetComponent<Renderer>().material = LetraI;
			RomboId04.GetComponent<Renderer>().material = LetraA;
			RomboId05.GetComponent<Renderer>().material = LetraB;
			RomboId06.GetComponent<Renderer>().material = LetraT;
			RomboId07.GetComponent<Renderer>().material = LetraR;
			RomboId08.GetComponent<Renderer>().material = LetraE;
			break;
		case 4 :
			Palabra = "Medicina";

			RomboId01.GetComponent<Renderer>().material = LetraE;
			RomboId02.GetComponent<Renderer>().material = LetraD;
			RomboId03.GetComponent<Renderer>().material = LetraI;
			RomboId04.GetComponent<Renderer>().material = LetraM;
			RomboId05.GetComponent<Renderer>().material = LetraC;
			RomboId06.GetComponent<Renderer>().material = LetraA;
			RomboId07.GetComponent<Renderer>().material = LetraN;
			RomboId08.GetComponent<Renderer>().material = LetraI;
			break;
		case 5 :
			Palabra = "Reliquia";
			RomboId01.GetComponent<Renderer>().material = LetraU;
			RomboId02.GetComponent<Renderer>().material = LetraI;
			RomboId03.GetComponent<Renderer>().material = LetraA;
			RomboId04.GetComponent<Renderer>().material = LetraQ;
			RomboId05.GetComponent<Renderer>().material = LetraR;
			RomboId06.GetComponent<Renderer>().material = LetraI;
			RomboId07.GetComponent<Renderer>().material = LetraL;
			RomboId08.GetComponent<Renderer>().material = LetraE;
			break;
		case 6:
			Palabra = "Levantar";
			RomboId01.GetComponent<Renderer>().material = LetraA;
			RomboId02.GetComponent<Renderer>().material = LetraN;
			RomboId03.GetComponent<Renderer>().material = LetraT;
			RomboId04.GetComponent<Renderer>().material = LetraV;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraE;
			RomboId07.GetComponent<Renderer>().material = LetraL;
			RomboId08.GetComponent<Renderer>().material = LetraR;
			break;
		case 7 :
			Palabra = "Derramar";
			RomboId01.GetComponent<Renderer>().material = LetraM;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraR;
			RomboId04.GetComponent<Renderer>().material = LetraA;
			RomboId05.GetComponent<Renderer>().material = LetraE;
			RomboId06.GetComponent<Renderer>().material = LetraR;
			RomboId07.GetComponent<Renderer>().material = LetraR;
			RomboId08.GetComponent<Renderer>().material = LetraD;
			break;
		case 8 :
			Palabra = "Cubierto";
			RomboId01.GetComponent<Renderer>().material = LetraI;
			RomboId02.GetComponent<Renderer>().material = LetraB;
			RomboId03.GetComponent<Renderer>().material = LetraC;
			RomboId04.GetComponent<Renderer>().material = LetraE;
			RomboId05.GetComponent<Renderer>().material = LetraU;
			RomboId06.GetComponent<Renderer>().material = LetraR;
			RomboId07.GetComponent<Renderer>().material = LetraT;
			RomboId08.GetComponent<Renderer>().material = LetraO;
			//                ASKDJAS—LKDMASL—DALSD,AS—LDKASL—DKAS—L
			break;
		case 9 :
			Palabra = "Esconder";
			RomboId01.GetComponent<Renderer>().material = LetraN;
			RomboId02.GetComponent<Renderer>().material = LetraO;
			RomboId03.GetComponent<Renderer>().material = LetraC;
			RomboId04.GetComponent<Renderer>().material = LetraD;
			RomboId05.GetComponent<Renderer>().material = LetraS;
			RomboId06.GetComponent<Renderer>().material = LetraE;
			RomboId07.GetComponent<Renderer>().material = LetraR;
			RomboId08.GetComponent<Renderer>().material = LetraE;
			break;
		case 10 :
			Palabra = "Estrecho";
			RomboId01.GetComponent<Renderer>().material = LetraE;
			RomboId02.GetComponent<Renderer>().material = LetraS;
			RomboId03.GetComponent<Renderer>().material = LetraT;
			RomboId04.GetComponent<Renderer>().material = LetraE;
			RomboId05.GetComponent<Renderer>().material = LetraR;
			RomboId06.GetComponent<Renderer>().material = LetraC;
			RomboId07.GetComponent<Renderer>().material = LetraH;
			RomboId08.GetComponent<Renderer>().material = LetraO;
			break;
		case 11 :

			Palabra = "Desayuno";
			RomboId01.GetComponent<Renderer>().material = LetraO;
			RomboId02.GetComponent<Renderer>().material = LetraD;
			RomboId03.GetComponent<Renderer>().material = LetraE;
			RomboId04.GetComponent<Renderer>().material = LetraN;
			RomboId05.GetComponent<Renderer>().material = LetraS;
			RomboId06.GetComponent<Renderer>().material = LetraU;
			RomboId07.GetComponent<Renderer>().material = LetraY;
			RomboId08.GetComponent<Renderer>().material = LetraA;
			break;

		case 12 :
			Palabra = "Estudiar";
			RomboId01.GetComponent<Renderer>().material = LetraT;
			RomboId02.GetComponent<Renderer>().material = LetraS;
			RomboId03.GetComponent<Renderer>().material = LetraE;
			RomboId04.GetComponent<Renderer>().material = LetraU;
			RomboId05.GetComponent<Renderer>().material = LetraD;
			RomboId06.GetComponent<Renderer>().material = LetraR;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			RomboId08.GetComponent<Renderer>().material = LetraI;
			break;
		case 13 :
			Palabra = "Uniforme";
			RomboId01.GetComponent<Renderer>().material = LetraU;
			RomboId02.GetComponent<Renderer>().material = LetraE;
			RomboId03.GetComponent<Renderer>().material = LetraM;
			RomboId04.GetComponent<Renderer>().material = LetraN;
			RomboId05.GetComponent<Renderer>().material = LetraR;
			RomboId06.GetComponent<Renderer>().material = LetraI;
			RomboId07.GetComponent<Renderer>().material = LetraF;
			RomboId08.GetComponent<Renderer>().material = LetraO;
			break;
		case 14 :
			Palabra = "Celebrar";
			RomboId01.GetComponent<Renderer>().material = LetraB;
			RomboId02.GetComponent<Renderer>().material = LetraE;
			RomboId03.GetComponent<Renderer>().material = LetraL;
			RomboId04.GetComponent<Renderer>().material = LetraR;
			RomboId05.GetComponent<Renderer>().material = LetraE;
			RomboId06.GetComponent<Renderer>().material = LetraR;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			RomboId08.GetComponent<Renderer>().material = LetraC;
			break;
		case 15 :
			Palabra = "Derramar";
			RomboId01.GetComponent<Renderer>().material = LetraE;
			RomboId02.GetComponent<Renderer>().material = LetraR;
			RomboId03.GetComponent<Renderer>().material = LetraR;
			RomboId04.GetComponent<Renderer>().material = LetraD;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraR;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			RomboId08.GetComponent<Renderer>().material = LetraM;
			break;
		case 16:
			Palabra = "Despedir";
			RomboId01.GetComponent<Renderer>().material = LetraP;
			RomboId02.GetComponent<Renderer>().material = LetraE;
			RomboId03.GetComponent<Renderer>().material = LetraD;
			RomboId04.GetComponent<Renderer>().material = LetraS;
			RomboId05.GetComponent<Renderer>().material = LetraI;
			RomboId06.GetComponent<Renderer>().material = LetraE;
			RomboId07.GetComponent<Renderer>().material = LetraD;
			RomboId08.GetComponent<Renderer>().material = LetraR;
			break;
		case 17 :
			Palabra = "Cardumen";
			RomboId01.GetComponent<Renderer>().material = LetraN;
			RomboId02.GetComponent<Renderer>().material = LetraE;
			RomboId03.GetComponent<Renderer>().material = LetraM;
			RomboId04.GetComponent<Renderer>().material = LetraA;
			RomboId05.GetComponent<Renderer>().material = LetraU;
			RomboId06.GetComponent<Renderer>().material = LetraC;
			RomboId07.GetComponent<Renderer>().material = LetraR;
			RomboId08.GetComponent<Renderer>().material = LetraD;
			break;
		case 18 :
			Palabra = "Castigar";
			RomboId01.GetComponent<Renderer>().material = LetraG;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraR;
			RomboId04.GetComponent<Renderer>().material = LetraI;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraT;
			RomboId07.GetComponent<Renderer>().material = LetraS;
			RomboId08.GetComponent<Renderer>().material = LetraC;
			break;
		case 19 :
			Palabra = "Desfilar";
			RomboId01.GetComponent<Renderer>().material = LetraR;
			RomboId02.GetComponent<Renderer>().material = LetraD;
			RomboId03.GetComponent<Renderer>().material = LetraE;
			RomboId04.GetComponent<Renderer>().material = LetraA;
			RomboId05.GetComponent<Renderer>().material = LetraS;
			RomboId06.GetComponent<Renderer>().material = LetraL;
			RomboId07.GetComponent<Renderer>().material = LetraI;
			RomboId08.GetComponent<Renderer>().material = LetraF;
			break;
		case 20 :
			Palabra = "Celebrar";
			RomboId01.GetComponent<Renderer>().material = LetraC;
			RomboId02.GetComponent<Renderer>().material = LetraE;
			RomboId03.GetComponent<Renderer>().material = LetraL;
			RomboId04.GetComponent<Renderer>().material = LetraB;
			RomboId05.GetComponent<Renderer>().material = LetraE;
			RomboId06.GetComponent<Renderer>().material = LetraR;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			RomboId08.GetComponent<Renderer>().material = LetraR;
			break;
		case 21 :

			Palabra = "Ascensor";
			RomboId01.GetComponent<Renderer>().material = LetraR;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraS;
			RomboId04.GetComponent<Renderer>().material = LetraO;
			RomboId05.GetComponent<Renderer>().material = LetraC;
			RomboId06.GetComponent<Renderer>().material = LetraS;
			RomboId07.GetComponent<Renderer>().material = LetraN;
			RomboId08.GetComponent<Renderer>().material = LetraE;
			break;

		case 22 :
			Palabra = "Costilla";
			RomboId01.GetComponent<Renderer>().material = LetraL;
			RomboId02.GetComponent<Renderer>().material = LetraI;
			RomboId03.GetComponent<Renderer>().material = LetraT;
			RomboId04.GetComponent<Renderer>().material = LetraL;
			RomboId05.GetComponent<Renderer>().material = LetraS;
			RomboId06.GetComponent<Renderer>().material = LetraA;
			RomboId07.GetComponent<Renderer>().material = LetraC;
			RomboId08.GetComponent<Renderer>().material = LetraO;
			break;
		case 23 :
			Palabra = "Degustar";
			RomboId01.GetComponent<Renderer>().material = LetraE;
			RomboId02.GetComponent<Renderer>().material = LetraD;
			RomboId03.GetComponent<Renderer>().material = LetraR;
			RomboId04.GetComponent<Renderer>().material = LetraG;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraU;
			RomboId07.GetComponent<Renderer>().material = LetraS;
			RomboId08.GetComponent<Renderer>().material = LetraT;
			break;
		case 24 :
			Palabra = "Escuchar";
			RomboId01.GetComponent<Renderer>().material = LetraR;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraH;
			RomboId04.GetComponent<Renderer>().material = LetraE;
			RomboId05.GetComponent<Renderer>().material = LetraC;
			RomboId06.GetComponent<Renderer>().material = LetraS;
			RomboId07.GetComponent<Renderer>().material = LetraC;
			RomboId08.GetComponent<Renderer>().material = LetraU;
			break;
		case 25 :
			Palabra = "Retorcer";
			RomboId01.GetComponent<Renderer>().material = LetraE;
			RomboId02.GetComponent<Renderer>().material = LetraT;
			RomboId03.GetComponent<Renderer>().material = LetraO;
			RomboId04.GetComponent<Renderer>().material = LetraR;
			RomboId05.GetComponent<Renderer>().material = LetraR;
			RomboId06.GetComponent<Renderer>().material = LetraR;
			RomboId07.GetComponent<Renderer>().material = LetraE;
			RomboId08.GetComponent<Renderer>().material = LetraC;
			break;
		case 26:
			Palabra = "Masticar";
			RomboId01.GetComponent<Renderer>().material = LetraC;
			RomboId02.GetComponent<Renderer>().material = LetraI;
			RomboId03.GetComponent<Renderer>().material = LetraT;
			RomboId04.GetComponent<Renderer>().material = LetraA;
			RomboId05.GetComponent<Renderer>().material = LetraS;
			RomboId06.GetComponent<Renderer>().material = LetraR;
			RomboId07.GetComponent<Renderer>().material = LetraM;
			RomboId08.GetComponent<Renderer>().material = LetraA;
			break;
		case 27 :
			Palabra = "Estrella";
			RomboId01.GetComponent<Renderer>().material = LetraR;
			RomboId02.GetComponent<Renderer>().material = LetraE;
			RomboId03.GetComponent<Renderer>().material = LetraL;
			RomboId04.GetComponent<Renderer>().material = LetraT;
			RomboId05.GetComponent<Renderer>().material = LetraL;
			RomboId06.GetComponent<Renderer>().material = LetraS;
			RomboId07.GetComponent<Renderer>().material = LetraE;
			RomboId08.GetComponent<Renderer>().material = LetraA;
			break;
		case 28 :
			Palabra = "Almuerzo";
			RomboId01.GetComponent<Renderer>().material = LetraU;
			RomboId02.GetComponent<Renderer>().material = LetraM;
			RomboId03.GetComponent<Renderer>().material = LetraA;
			RomboId04.GetComponent<Renderer>().material = LetraE;
			RomboId05.GetComponent<Renderer>().material = LetraL;
			RomboId06.GetComponent<Renderer>().material = LetraR;
			RomboId07.GetComponent<Renderer>().material = LetraZ;
			RomboId08.GetComponent<Renderer>().material = LetraO;
			break;
		case 29 :
			Palabra = "Bacteria";
			RomboId01.GetComponent<Renderer>().material = LetraR;
			RomboId02.GetComponent<Renderer>().material = LetraI;
			RomboId03.GetComponent<Renderer>().material = LetraA;
			RomboId04.GetComponent<Renderer>().material = LetraE;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraT;
			RomboId07.GetComponent<Renderer>().material = LetraC;
			RomboId08.GetComponent<Renderer>().material = LetraB;
			break;
		case 30 :
			Palabra = "Delantal";
			RomboId01.GetComponent<Renderer>().material = LetraD;
			RomboId02.GetComponent<Renderer>().material = LetraL;
			RomboId03.GetComponent<Renderer>().material = LetraA;
			RomboId04.GetComponent<Renderer>().material = LetraE;
			RomboId05.GetComponent<Renderer>().material = LetraN;
			RomboId06.GetComponent<Renderer>().material = LetraL;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			RomboId08.GetComponent<Renderer>().material = LetraT;
			break;
		}


	}

	void Update(){
		Vidas = PlayerPrefs.GetInt ("Vidas");
	}
}
