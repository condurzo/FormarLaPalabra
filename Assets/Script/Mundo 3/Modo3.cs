using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Modo3 : MonoBehaviour {


	public GameObject RomboId01;
	public GameObject RomboId02;
	public GameObject RomboId03;
	public GameObject RomboId04;
	public GameObject RomboId05;
	public GameObject RomboId06;
	public GameObject RomboId07;
	public GameObject RomboId08;
	public GameObject RomboId09;
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
		if (PlayerPrefs.GetInt ("level3") == 30) {
			PlayerPrefs.SetInt ("Desblo-Nivel4-Ver1", 1);
			PlayerPrefs.SetInt ("Stop-Nivel3-Ver1", 1);
			PlayerPrefs.SetInt ("Desblo-Nivel3-Ver1", 0);
			Modo1Puntos.Victoria = false;
			CountdownTimer_CSHARP.TerminoPartida = false;
			Application.LoadLevel ("SelectorMundos");
		} else {
			Modo1Puntos.Victoria = false;
			CountdownTimer_CSHARP.TerminoPartida = false;
			SceneManager.LoadScene ("Nivel3");
		}
	}
	void Atras(){
		mostrador = PlayerPrefs.GetInt ("MostrarInterstitial");
		mostrador++;
		PlayerPrefs.SetInt ("MostrarInterstitial", mostrador);
		PlayerPrefs.SetInt ("PerdioPrimera",0);
		if (PlayerPrefs.GetInt ("level3") == 30) {
			PlayerPrefs.SetInt ("Desblo-Nivel4-Ver1", 1);
			PlayerPrefs.SetInt ("Stop-Nivel3-Ver1", 1);
			PlayerPrefs.SetInt ("Desblo-Nivel3-Ver1", 0);
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
			Application.LoadLevel("Nivel3");
		} else {
			Application.LoadLevel ("SelectorMundos");
		}

	}

	void Start () {
		System.GC.Collect();
		Level = PlayerPrefs.GetInt("level3");
		switch (Level){
		case 1 :

			Palabra = "Malabares";
			RomboId01.GetComponent<Renderer>().material = LetraM;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraL;
			RomboId04.GetComponent<Renderer>().material = LetraR;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraB;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			RomboId08.GetComponent<Renderer>().material = LetraE;
			RomboId09.GetComponent<Renderer>().material = LetraS;
			break;

		case 2 :

			Palabra= "Dificulta";

			RomboId01.GetComponent<Renderer>().material = LetraL;
			RomboId02.GetComponent<Renderer>().material = LetraT;
			RomboId03.GetComponent<Renderer>().material = LetraI;
			RomboId04.GetComponent<Renderer>().material = LetraU;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraF;
			RomboId07.GetComponent<Renderer>().material = LetraD;
			RomboId08.GetComponent<Renderer>().material = LetraC;
			RomboId09.GetComponent<Renderer>().material = LetraI;
			break;
		case 3 :
			Palabra = "Coleccion";

			RomboId01.GetComponent<Renderer>().material = LetraC;
			RomboId02.GetComponent<Renderer>().material = LetraI;
			RomboId03.GetComponent<Renderer>().material = LetraO;
			RomboId04.GetComponent<Renderer>().material = LetraE;
			RomboId05.GetComponent<Renderer>().material = LetraC;
			RomboId06.GetComponent<Renderer>().material = LetraC;
			RomboId07.GetComponent<Renderer>().material = LetraN;
			RomboId08.GetComponent<Renderer>().material = LetraL;
			RomboId09.GetComponent<Renderer>().material = LetraO;
			break;
		case 4 :
			Palabra = "Mariposas";

			RomboId01.GetComponent<Renderer>().material = LetraO;
			RomboId02.GetComponent<Renderer>().material = LetraS;
			RomboId03.GetComponent<Renderer>().material = LetraA;
			RomboId04.GetComponent<Renderer>().material = LetraP;
			RomboId05.GetComponent<Renderer>().material = LetraM;
			RomboId06.GetComponent<Renderer>().material = LetraA;
			RomboId07.GetComponent<Renderer>().material = LetraS;
			RomboId08.GetComponent<Renderer>().material = LetraI;
			RomboId09.GetComponent<Renderer>().material = LetraR;
			break;
		case 5 :
			Palabra = "Intelecto";
			RomboId01.GetComponent<Renderer>().material = LetraN;
			RomboId02.GetComponent<Renderer>().material = LetraI;
			RomboId03.GetComponent<Renderer>().material = LetraT;
			RomboId04.GetComponent<Renderer>().material = LetraE;
			RomboId05.GetComponent<Renderer>().material = LetraT;
			RomboId06.GetComponent<Renderer>().material = LetraC;
			RomboId07.GetComponent<Renderer>().material = LetraO;
			RomboId08.GetComponent<Renderer>().material = LetraL;
			RomboId09.GetComponent<Renderer>().material = LetraE;
			break;
		case 6:
			Palabra = "Embalajes";
			RomboId01.GetComponent<Renderer>().material = LetraE;
			RomboId02.GetComponent<Renderer>().material = LetraJ;
			RomboId03.GetComponent<Renderer>().material = LetraA;
			RomboId04.GetComponent<Renderer>().material = LetraS;
			RomboId05.GetComponent<Renderer>().material = LetraB;
			RomboId06.GetComponent<Renderer>().material = LetraA;
			RomboId07.GetComponent<Renderer>().material = LetraL;
			RomboId08.GetComponent<Renderer>().material = LetraM;
			RomboId09.GetComponent<Renderer>().material = LetraE;
			break;
		case 7 :
			Palabra = "Politicas";
			RomboId01.GetComponent<Renderer>().material = LetraI;
			RomboId02.GetComponent<Renderer>().material = LetraL;
			RomboId03.GetComponent<Renderer>().material = LetraO;
			RomboId04.GetComponent<Renderer>().material = LetraT;
			RomboId05.GetComponent<Renderer>().material = LetraI;
			RomboId06.GetComponent<Renderer>().material = LetraS;
			RomboId07.GetComponent<Renderer>().material = LetraP;
			RomboId08.GetComponent<Renderer>().material = LetraC;
			RomboId09.GetComponent<Renderer>().material = LetraA;
			break;
		case 8 :
			Palabra = "Religioso";
			RomboId01.GetComponent<Renderer>().material = LetraE;
			RomboId02.GetComponent<Renderer>().material = LetraR;
			RomboId03.GetComponent<Renderer>().material = LetraS;
			RomboId04.GetComponent<Renderer>().material = LetraL;
			RomboId05.GetComponent<Renderer>().material = LetraG;
			RomboId06.GetComponent<Renderer>().material = LetraO;
			RomboId07.GetComponent<Renderer>().material = LetraO;
			RomboId08.GetComponent<Renderer>().material = LetraI;
			RomboId09.GetComponent<Renderer>().material = LetraI;
			break;
		case 9 :
			Palabra = "Licuadora";
			RomboId01.GetComponent<Renderer>().material = LetraL;
			RomboId02.GetComponent<Renderer>().material = LetraO;
			RomboId03.GetComponent<Renderer>().material = LetraR;
			RomboId04.GetComponent<Renderer>().material = LetraI;
			RomboId05.GetComponent<Renderer>().material = LetraU;
			RomboId06.GetComponent<Renderer>().material = LetraD;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			RomboId08.GetComponent<Renderer>().material = LetraC;
			RomboId09.GetComponent<Renderer>().material = LetraA;
			break;
		case 10 :
			Palabra = "Televisor";
			RomboId01.GetComponent<Renderer>().material = LetraS;
			RomboId02.GetComponent<Renderer>().material = LetraO;
			RomboId03.GetComponent<Renderer>().material = LetraR;
			RomboId04.GetComponent<Renderer>().material = LetraI;
			RomboId05.GetComponent<Renderer>().material = LetraL;
			RomboId06.GetComponent<Renderer>().material = LetraE;
			RomboId07.GetComponent<Renderer>().material = LetraT;
			RomboId08.GetComponent<Renderer>().material = LetraV;
			RomboId09.GetComponent<Renderer>().material = LetraE;
			break;
		case 11 :

			Palabra = "Reportaje";
			RomboId01.GetComponent<Renderer>().material = LetraR;
			RomboId02.GetComponent<Renderer>().material = LetraE;
			RomboId03.GetComponent<Renderer>().material = LetraE;
			RomboId04.GetComponent<Renderer>().material = LetraO;
			RomboId05.GetComponent<Renderer>().material = LetraP;
			RomboId06.GetComponent<Renderer>().material = LetraA;
			RomboId07.GetComponent<Renderer>().material = LetraJ;
			RomboId08.GetComponent<Renderer>().material = LetraR;
			RomboId09.GetComponent<Renderer>().material = LetraT;
			break;

		case 12 :
			Palabra = "Visitante";
			RomboId01.GetComponent<Renderer>().material = LetraE;
			RomboId02.GetComponent<Renderer>().material = LetraT;
			RomboId03.GetComponent<Renderer>().material = LetraI;
			RomboId04.GetComponent<Renderer>().material = LetraT;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraI;
			RomboId07.GetComponent<Renderer>().material = LetraS;
			RomboId08.GetComponent<Renderer>().material = LetraN;
			RomboId09.GetComponent<Renderer>().material = LetraV;
			break;
		case 13 :
			Palabra = "Colegiala";
			RomboId01.GetComponent<Renderer>().material = LetraE;
			RomboId02.GetComponent<Renderer>().material = LetraG;
			RomboId03.GetComponent<Renderer>().material = LetraI;
			RomboId04.GetComponent<Renderer>().material = LetraL;
			RomboId05.GetComponent<Renderer>().material = LetraC;
			RomboId06.GetComponent<Renderer>().material = LetraL;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			RomboId08.GetComponent<Renderer>().material = LetraO;
			RomboId09.GetComponent<Renderer>().material = LetraA;
			break;
		case 14 :
			Palabra = "Vertebras";
			RomboId01.GetComponent<Renderer>().material = LetraB;
			RomboId02.GetComponent<Renderer>().material = LetraE;
			RomboId03.GetComponent<Renderer>().material = LetraT;
			RomboId04.GetComponent<Renderer>().material = LetraR;
			RomboId05.GetComponent<Renderer>().material = LetraV;
			RomboId06.GetComponent<Renderer>().material = LetraE;
			RomboId07.GetComponent<Renderer>().material = LetraR;
			RomboId08.GetComponent<Renderer>().material = LetraA;
			RomboId09.GetComponent<Renderer>().material = LetraS;
			break;
		case 15 :
			Palabra = "Microbios";
			RomboId01.GetComponent<Renderer>().material = LetraS;
			RomboId02.GetComponent<Renderer>().material = LetraR;
			RomboId03.GetComponent<Renderer>().material = LetraC;
			RomboId04.GetComponent<Renderer>().material = LetraO;
			RomboId05.GetComponent<Renderer>().material = LetraO;
			RomboId06.GetComponent<Renderer>().material = LetraM;
			RomboId07.GetComponent<Renderer>().material = LetraI;
			RomboId08.GetComponent<Renderer>().material = LetraI;
			RomboId09.GetComponent<Renderer>().material = LetraB;
			break;
		case 16:
			Palabra = "Asesinato";
			RomboId01.GetComponent<Renderer>().material = LetraO;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraS;
			RomboId04.GetComponent<Renderer>().material = LetraT;
			RomboId05.GetComponent<Renderer>().material = LetraI;
			RomboId06.GetComponent<Renderer>().material = LetraS;
			RomboId07.GetComponent<Renderer>().material = LetraE;
			RomboId08.GetComponent<Renderer>().material = LetraA;
			RomboId09.GetComponent<Renderer>().material = LetraN;
			break;
		case 17 :
			Palabra = "Imposible";
			RomboId01.GetComponent<Renderer>().material = LetraI;
			RomboId02.GetComponent<Renderer>().material = LetraM;
			RomboId03.GetComponent<Renderer>().material = LetraP;
			RomboId04.GetComponent<Renderer>().material = LetraB;
			RomboId05.GetComponent<Renderer>().material = LetraI;
			RomboId06.GetComponent<Renderer>().material = LetraS;
			RomboId07.GetComponent<Renderer>().material = LetraO;
			RomboId08.GetComponent<Renderer>().material = LetraL;
			RomboId09.GetComponent<Renderer>().material = LetraE;
			break;
		case 18 :
			Palabra = "Investiga";
			RomboId01.GetComponent<Renderer>().material = LetraA;
			RomboId02.GetComponent<Renderer>().material = LetraG;
			RomboId03.GetComponent<Renderer>().material = LetraI;
			RomboId04.GetComponent<Renderer>().material = LetraN;
			RomboId05.GetComponent<Renderer>().material = LetraI;
			RomboId06.GetComponent<Renderer>().material = LetraS;
			RomboId07.GetComponent<Renderer>().material = LetraT;
			RomboId08.GetComponent<Renderer>().material = LetraV;
			RomboId09.GetComponent<Renderer>().material = LetraE;
			break;
		case 19 :
			Palabra = "Jardinero";
			RomboId01.GetComponent<Renderer>().material = LetraO;
			RomboId02.GetComponent<Renderer>().material = LetraJ;
			RomboId03.GetComponent<Renderer>().material = LetraA;
			RomboId04.GetComponent<Renderer>().material = LetraR;
			RomboId05.GetComponent<Renderer>().material = LetraE;
			RomboId06.GetComponent<Renderer>().material = LetraD;
			RomboId07.GetComponent<Renderer>().material = LetraR;
			RomboId08.GetComponent<Renderer>().material = LetraN;
			RomboId09.GetComponent<Renderer>().material = LetraI;
			break;
		case 20 :
			Palabra = "Serpiente";
			RomboId01.GetComponent<Renderer>().material = LetraE;
			RomboId02.GetComponent<Renderer>().material = LetraN;
			RomboId03.GetComponent<Renderer>().material = LetraT;
			RomboId04.GetComponent<Renderer>().material = LetraR;
			RomboId05.GetComponent<Renderer>().material = LetraS;
			RomboId06.GetComponent<Renderer>().material = LetraE;
			RomboId07.GetComponent<Renderer>().material = LetraE;
			RomboId08.GetComponent<Renderer>().material = LetraP;
			RomboId09.GetComponent<Renderer>().material = LetraI;
			break;
		case 21 :

			Palabra = "Cucaracha";
			RomboId01.GetComponent<Renderer>().material = LetraC;
			RomboId02.GetComponent<Renderer>().material = LetraU;
			RomboId03.GetComponent<Renderer>().material = LetraC;
			RomboId04.GetComponent<Renderer>().material = LetraH;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraR;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			RomboId08.GetComponent<Renderer>().material = LetraC;
			RomboId09.GetComponent<Renderer>().material = LetraA;
			break;

		case 22 :
			Palabra = "Porqueria";
			RomboId01.GetComponent<Renderer>().material = LetraE;
			RomboId02.GetComponent<Renderer>().material = LetraR;
			RomboId03.GetComponent<Renderer>().material = LetraI;
			RomboId04.GetComponent<Renderer>().material = LetraU;
			RomboId05.GetComponent<Renderer>().material = LetraR;
			RomboId06.GetComponent<Renderer>().material = LetraP;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			RomboId08.GetComponent<Renderer>().material = LetraQ;
			RomboId09.GetComponent<Renderer>().material = LetraO;
			break;
		case 23 :
			Palabra = "Circuitos";
			RomboId01.GetComponent<Renderer>().material = LetraR;
			RomboId02.GetComponent<Renderer>().material = LetraC;
			RomboId03.GetComponent<Renderer>().material = LetraO;
			RomboId04.GetComponent<Renderer>().material = LetraC;
			RomboId05.GetComponent<Renderer>().material = LetraI;
			RomboId06.GetComponent<Renderer>().material = LetraT;
			RomboId07.GetComponent<Renderer>().material = LetraS;
			RomboId08.GetComponent<Renderer>().material = LetraU;
			RomboId09.GetComponent<Renderer>().material = LetraI;
			break;
		case 24 :
			Palabra = "Medicinal";
			RomboId01.GetComponent<Renderer>().material = LetraI;
			RomboId02.GetComponent<Renderer>().material = LetraI;
			RomboId03.GetComponent<Renderer>().material = LetraE;
			RomboId04.GetComponent<Renderer>().material = LetraN;
			RomboId05.GetComponent<Renderer>().material = LetraC;
			RomboId06.GetComponent<Renderer>().material = LetraD;
			RomboId07.GetComponent<Renderer>().material = LetraM;
			RomboId08.GetComponent<Renderer>().material = LetraA;
			RomboId09.GetComponent<Renderer>().material = LetraL;
			break;
		case 25 :
			Palabra = "Perjudica";
			RomboId01.GetComponent<Renderer>().material = LetraD;
			RomboId02.GetComponent<Renderer>().material = LetraU;
			RomboId03.GetComponent<Renderer>().material = LetraJ;
			RomboId04.GetComponent<Renderer>().material = LetraI;
			RomboId05.GetComponent<Renderer>().material = LetraP;
			RomboId06.GetComponent<Renderer>().material = LetraE;
			RomboId07.GetComponent<Renderer>().material = LetraR;
			RomboId08.GetComponent<Renderer>().material = LetraC;
			RomboId09.GetComponent<Renderer>().material = LetraA;
			break;
		case 26:
			Palabra = "Melocoton";
			RomboId01.GetComponent<Renderer>().material = LetraC;
			RomboId02.GetComponent<Renderer>().material = LetraO;
			RomboId03.GetComponent<Renderer>().material = LetraO;
			RomboId04.GetComponent<Renderer>().material = LetraO;
			RomboId05.GetComponent<Renderer>().material = LetraM;
			RomboId06.GetComponent<Renderer>().material = LetraT;
			RomboId07.GetComponent<Renderer>().material = LetraN;
			RomboId08.GetComponent<Renderer>().material = LetraL;
			RomboId09.GetComponent<Renderer>().material = LetraE;
			break;
		case 27 :
			Palabra = "Esparragp";
			RomboId01.GetComponent<Renderer>().material = LetraE;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraG;
			RomboId04.GetComponent<Renderer>().material = LetraP;
			RomboId05.GetComponent<Renderer>().material = LetraS;
			RomboId06.GetComponent<Renderer>().material = LetraR;
			RomboId07.GetComponent<Renderer>().material = LetraO;
			RomboId08.GetComponent<Renderer>().material = LetraA;
			RomboId09.GetComponent<Renderer>().material = LetraR;
			break;
		case 28 :
			Palabra = "Infalible";
			RomboId01.GetComponent<Renderer>().material = LetraB;
			RomboId02.GetComponent<Renderer>().material = LetraI;
			RomboId03.GetComponent<Renderer>().material = LetraL;
			RomboId04.GetComponent<Renderer>().material = LetraL;
			RomboId05.GetComponent<Renderer>().material = LetraI;
			RomboId06.GetComponent<Renderer>().material = LetraF;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			RomboId08.GetComponent<Renderer>().material = LetraE;
			RomboId09.GetComponent<Renderer>().material = LetraN;
			break;
		case 29 :
			Palabra = "Ordenador";
			RomboId01.GetComponent<Renderer>().material = LetraO;
			RomboId02.GetComponent<Renderer>().material = LetraD;
			RomboId03.GetComponent<Renderer>().material = LetraO;
			RomboId04.GetComponent<Renderer>().material = LetraR;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraD;
			RomboId07.GetComponent<Renderer>().material = LetraR;
			RomboId08.GetComponent<Renderer>().material = LetraN;
			RomboId09.GetComponent<Renderer>().material = LetraE;
			break;
		case 30 :
			Palabra = "Camisetas";
			RomboId01.GetComponent<Renderer>().material = LetraA;
			RomboId02.GetComponent<Renderer>().material = LetraC;
			RomboId03.GetComponent<Renderer>().material = LetraS;
			RomboId04.GetComponent<Renderer>().material = LetraM;
			RomboId05.GetComponent<Renderer>().material = LetraS;
			RomboId06.GetComponent<Renderer>().material = LetraT;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			RomboId08.GetComponent<Renderer>().material = LetraI;
			RomboId09.GetComponent<Renderer>().material = LetraE;
			break;
		}


	}

	void Update(){
		Vidas = PlayerPrefs.GetInt ("Vidas");
	}

}
