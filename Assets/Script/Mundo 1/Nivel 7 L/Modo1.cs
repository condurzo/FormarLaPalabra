using UnityEngine;
using System.Collections;

public class Modo1 : MonoBehaviour {


	public GameObject RomboId01;
	public GameObject RomboId02;
	public GameObject RomboId03;
	public GameObject RomboId04;
	public GameObject RomboId05;
	public GameObject RomboId06;
	public GameObject RomboId07;
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

	public int Vidas;

	public int mostrador;

	void Avanzar(){
		mostrador = PlayerPrefs.GetInt ("MostrarInterstitial");
		mostrador++;
		PlayerPrefs.SetInt ("MostrarInterstitial", mostrador);
		PlayerPrefs.SetInt ("PerdioPrimera",0);
		if (PlayerPrefs.GetInt ("level") == 30) {
			PlayerPrefs.SetInt ("Desblo-Nivel2-Ver1", 1);
			PlayerPrefs.SetInt ("Stop-Nivel1-Ver1", 1);
			PlayerPrefs.SetInt ("Desblo-Nivel1-Ver1", 0);
			Modo1Puntos.Victoria = false;
			CountdownTimer_CSHARP.TerminoPartida = false;
			Application.LoadLevel ("SelectorMundos");
		} else {
			Modo1Puntos.Victoria = false;
			CountdownTimer_CSHARP.TerminoPartida = false;
			Application.LoadLevel ("Nivel1");
		}
	}
	void Atras(){
		mostrador = PlayerPrefs.GetInt ("MostrarInterstitial");
		mostrador++;
		PlayerPrefs.SetInt ("MostrarInterstitial", mostrador);
		PlayerPrefs.SetInt ("PerdioPrimera",0);
		if (PlayerPrefs.GetInt ("level") == 30) {
			PlayerPrefs.SetInt ("Desblo-Nivel2-Ver1", 1);
			PlayerPrefs.SetInt ("Stop-Nivel1-Ver1", 1);
			PlayerPrefs.SetInt ("Desblo-Nivel1-Ver1", 0);
			Modo1Puntos.Victoria = false;
			CountdownTimer_CSHARP.TerminoPartida = false;
			Application.LoadLevel ("SelectorMundos");
		} else {
			Modo1Puntos.Victoria = false;
			CountdownTimer_CSHARP.TerminoPartida = false;
			Application.LoadLevel ("SelectorMundos");
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
			Application.LoadLevel("Nivel1");
		} else {
			Application.LoadLevel ("SelectorMundos");
		}

	}


	void Start () {
		System.GC.Collect();
		Level = PlayerPrefs.GetInt("level");
		switch (Level){
		case 1 :
			
			Palabra = "Abogado";
			RomboId01.GetComponent<Renderer>().material = LetraO;
			RomboId02.GetComponent<Renderer>().material = LetraD;
			RomboId03.GetComponent<Renderer>().material = LetraA;
			RomboId04.GetComponent<Renderer>().material = LetraO;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraB;
			RomboId07.GetComponent<Renderer>().material = LetraG;
			break;
			
		case 2 :
			
			Palabra= "Acarreo";
			
			RomboId01.GetComponent<Renderer>().material = LetraR;
			RomboId02.GetComponent<Renderer>().material = LetraE;
			RomboId03.GetComponent<Renderer>().material = LetraR;
			RomboId04.GetComponent<Renderer>().material = LetraO;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraA;
			RomboId07.GetComponent<Renderer>().material = LetraC;
			break;
		case 3 :
			Palabra = "Billete";
			
			RomboId01.GetComponent<Renderer>().material = LetraE;
			RomboId02.GetComponent<Renderer>().material = LetraT;
			RomboId03.GetComponent<Renderer>().material = LetraB;
			RomboId04.GetComponent<Renderer>().material = LetraI;
			RomboId05.GetComponent<Renderer>().material = LetraE;
			RomboId06.GetComponent<Renderer>().material = LetraL;
			RomboId07.GetComponent<Renderer>().material = LetraL;
			break;
		case 4 :
			Palabra = "Planeta";
			
			RomboId01.GetComponent<Renderer>().material = LetraL;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraP;
			RomboId04.GetComponent<Renderer>().material = LetraE;
			RomboId05.GetComponent<Renderer>().material = LetraN;
			RomboId06.GetComponent<Renderer>().material = LetraA;
			RomboId07.GetComponent<Renderer>().material = LetraT;
			break;
		case 5 :
			Palabra = "Botella";
			RomboId01.GetComponent<Renderer>().material = LetraO;
			RomboId02.GetComponent<Renderer>().material = LetraT;
			RomboId03.GetComponent<Renderer>().material = LetraB;
			RomboId04.GetComponent<Renderer>().material = LetraA;
			RomboId05.GetComponent<Renderer>().material = LetraE;
			RomboId06.GetComponent<Renderer>().material = LetraL;
			RomboId07.GetComponent<Renderer>().material = LetraL;
			break;
		case 6:
			Palabra = "Cocinar";
			RomboId01.GetComponent<Renderer>().material = LetraI;
			RomboId02.GetComponent<Renderer>().material = LetraR;
			RomboId03.GetComponent<Renderer>().material = LetraC;
			RomboId04.GetComponent<Renderer>().material = LetraN;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraO;
			RomboId07.GetComponent<Renderer>().material = LetraC;
			break;
		case 7 :
			Palabra = "Galopar";
			RomboId01.GetComponent<Renderer>().material = LetraG;
			RomboId02.GetComponent<Renderer>().material = LetraO;
			RomboId03.GetComponent<Renderer>().material = LetraA;
			RomboId04.GetComponent<Renderer>().material = LetraL;
			RomboId05.GetComponent<Renderer>().material = LetraP;
			RomboId06.GetComponent<Renderer>().material = LetraR;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			break;
		case 8 :
			Palabra = "Llavero";
			RomboId01.GetComponent<Renderer>().material = LetraA;
			RomboId02.GetComponent<Renderer>().material = LetraV;
			RomboId03.GetComponent<Renderer>().material = LetraL;
			RomboId04.GetComponent<Renderer>().material = LetraO;
			RomboId05.GetComponent<Renderer>().material = LetraE;
			RomboId06.GetComponent<Renderer>().material = LetraL;
			RomboId07.GetComponent<Renderer>().material = LetraR;
			//                ASKDJAS—LKDMASL—DALSD,AS—LDKASL—DKAS—L
			break;
		case 9 :
			Palabra = "Mensaje";
			RomboId01.GetComponent<Renderer>().material = LetraE;
			RomboId02.GetComponent<Renderer>().material = LetraM;
			RomboId03.GetComponent<Renderer>().material = LetraJ;
			RomboId04.GetComponent<Renderer>().material = LetraN;
			RomboId05.GetComponent<Renderer>().material = LetraE;
			RomboId06.GetComponent<Renderer>().material = LetraA;
			RomboId07.GetComponent<Renderer>().material = LetraS;
			break;
		case 10 :
			Palabra = "Premiar";
			RomboId01.GetComponent<Renderer>().material = LetraE;
			RomboId02.GetComponent<Renderer>().material = LetraM;
			RomboId03.GetComponent<Renderer>().material = LetraP;
			RomboId04.GetComponent<Renderer>().material = LetraR;
			RomboId05.GetComponent<Renderer>().material = LetraI;
			RomboId06.GetComponent<Renderer>().material = LetraR;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			break;
		case 11 :
			
			Palabra = "Cristal";
			RomboId01.GetComponent<Renderer>().material = LetraR;
			RomboId02.GetComponent<Renderer>().material = LetraS;
			RomboId03.GetComponent<Renderer>().material = LetraC;
			RomboId04.GetComponent<Renderer>().material = LetraI;
			RomboId05.GetComponent<Renderer>().material = LetraT;
			RomboId06.GetComponent<Renderer>().material = LetraL;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			break;
			
		case 12 :
			Palabra = "Iguales";
			RomboId01.GetComponent<Renderer>().material = LetraS;
			RomboId02.GetComponent<Renderer>().material = LetraG;
			RomboId03.GetComponent<Renderer>().material = LetraE;
			RomboId04.GetComponent<Renderer>().material = LetraI;
			RomboId05.GetComponent<Renderer>().material = LetraU;
			RomboId06.GetComponent<Renderer>().material = LetraL;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			break;
		case 13 :
			Palabra = "Nublado";
			RomboId01.GetComponent<Renderer>().material = LetraO;
			RomboId02.GetComponent<Renderer>().material = LetraN;
			RomboId03.GetComponent<Renderer>().material = LetraD;
			RomboId04.GetComponent<Renderer>().material = LetraU;
			RomboId05.GetComponent<Renderer>().material = LetraB;
			RomboId06.GetComponent<Renderer>().material = LetraA;
			RomboId07.GetComponent<Renderer>().material = LetraL;
			break;
		case 14 :
			Palabra = "Galeria";
			RomboId01.GetComponent<Renderer>().material = LetraG;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraE;
			RomboId04.GetComponent<Renderer>().material = LetraL;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraR;
			RomboId07.GetComponent<Renderer>().material = LetraI;
			break;
		case 15 :
			Palabra = "SALVAJE";
			RomboId01.GetComponent<Renderer>().material = LetraE;
			RomboId02.GetComponent<Renderer>().material = LetraJ;
			RomboId03.GetComponent<Renderer>().material = LetraS;
			RomboId04.GetComponent<Renderer>().material = LetraL;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraA;
			RomboId07.GetComponent<Renderer>().material = LetraV;
			break;
		case 16:
			Palabra = "DIBUJAR";
			RomboId01.GetComponent<Renderer>().material = LetraD;
			RomboId02.GetComponent<Renderer>().material = LetraI;
			RomboId03.GetComponent<Renderer>().material = LetraR;
			RomboId04.GetComponent<Renderer>().material = LetraB;
			RomboId05.GetComponent<Renderer>().material = LetraU;
			RomboId06.GetComponent<Renderer>().material = LetraA;
			RomboId07.GetComponent<Renderer>().material = LetraJ;
			break;
		case 17 :
			Palabra = "CARACOL";
			RomboId01.GetComponent<Renderer>().material = LetraO;
			RomboId02.GetComponent<Renderer>().material = LetraL;
			RomboId03.GetComponent<Renderer>().material = LetraC;
			RomboId04.GetComponent<Renderer>().material = LetraA;
			RomboId05.GetComponent<Renderer>().material = LetraC;
			RomboId06.GetComponent<Renderer>().material = LetraA;
			RomboId07.GetComponent<Renderer>().material = LetraR;
			break;
		case 18 :
			Palabra = "Hornerar";
			RomboId01.GetComponent<Renderer>().material = LetraR;
			RomboId02.GetComponent<Renderer>().material = LetraR;
			RomboId03.GetComponent<Renderer>().material = LetraA;
			RomboId04.GetComponent<Renderer>().material = LetraN;
			RomboId05.GetComponent<Renderer>().material = LetraO;
			RomboId06.GetComponent<Renderer>().material = LetraE;
			RomboId07.GetComponent<Renderer>().material = LetraH;
			break;
		case 19 :
			Palabra = "Ajustar";
			RomboId01.GetComponent<Renderer>().material = LetraR;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraA;
			RomboId04.GetComponent<Renderer>().material = LetraJ;
			RomboId05.GetComponent<Renderer>().material = LetraU;
			RomboId06.GetComponent<Renderer>().material = LetraT;
			RomboId07.GetComponent<Renderer>().material = LetraS;
			break;
		case 20 :
			Palabra = "Ganador";
			RomboId01.GetComponent<Renderer>().material = LetraA;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraG;
			RomboId04.GetComponent<Renderer>().material = LetraN;
			RomboId05.GetComponent<Renderer>().material = LetraD;
			RomboId06.GetComponent<Renderer>().material = LetraR;
			RomboId07.GetComponent<Renderer>().material = LetraO;
			break;
		case 21 :
			
			Palabra = "Esperar";
			RomboId01.GetComponent<Renderer>().material = LetraA;
			RomboId02.GetComponent<Renderer>().material = LetraR;
			RomboId03.GetComponent<Renderer>().material = LetraR;
			RomboId04.GetComponent<Renderer>().material = LetraE;
			RomboId05.GetComponent<Renderer>().material = LetraE;
			RomboId06.GetComponent<Renderer>().material = LetraS;
			RomboId07.GetComponent<Renderer>().material = LetraP;
			break;
			
		case 22 :
			Palabra = "Archivo";
			RomboId01.GetComponent<Renderer>().material = LetraV;
			RomboId02.GetComponent<Renderer>().material = LetraO;
			RomboId03.GetComponent<Renderer>().material = LetraI;
			RomboId04.GetComponent<Renderer>().material = LetraR;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraH;
			RomboId07.GetComponent<Renderer>().material = LetraC;
			break;
		case 23 :
			Palabra = "Padrino";
			RomboId01.GetComponent<Renderer>().material = LetraN;
			RomboId02.GetComponent<Renderer>().material = LetraO;
			RomboId03.GetComponent<Renderer>().material = LetraI;
			RomboId04.GetComponent<Renderer>().material = LetraD;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraR;
			RomboId07.GetComponent<Renderer>().material = LetraP;
			break;
		case 24 :
			Palabra = "Gaseosa";
			RomboId01.GetComponent<Renderer>().material = LetraO;
			RomboId02.GetComponent<Renderer>().material = LetraG;
			RomboId03.GetComponent<Renderer>().material = LetraS;
			RomboId04.GetComponent<Renderer>().material = LetraE;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraA;
			RomboId07.GetComponent<Renderer>().material = LetraS;
			break;
		case 25 :
			Palabra = "Mascara";
			RomboId01.GetComponent<Renderer>().material = LetraA;
			RomboId02.GetComponent<Renderer>().material = LetraA;
			RomboId03.GetComponent<Renderer>().material = LetraM;
			RomboId04.GetComponent<Renderer>().material = LetraS;
			RomboId05.GetComponent<Renderer>().material = LetraR;
			RomboId06.GetComponent<Renderer>().material = LetraC;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			break;
		case 26:
			Palabra = "Catorce";
			RomboId01.GetComponent<Renderer>().material = LetraR;
			RomboId02.GetComponent<Renderer>().material = LetraC;
			RomboId03.GetComponent<Renderer>().material = LetraO;
			RomboId04.GetComponent<Renderer>().material = LetraT;
			RomboId05.GetComponent<Renderer>().material = LetraE;
			RomboId06.GetComponent<Renderer>().material = LetraA;
			RomboId07.GetComponent<Renderer>().material = LetraC;
			break;
		case 27 :
			Palabra = "Corazon";
			RomboId01.GetComponent<Renderer>().material = LetraN;
			RomboId02.GetComponent<Renderer>().material = LetraO;
			RomboId03.GetComponent<Renderer>().material = LetraO;
			RomboId04.GetComponent<Renderer>().material = LetraR;
			RomboId05.GetComponent<Renderer>().material = LetraC;
			RomboId06.GetComponent<Renderer>().material = LetraZ;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			break;
		case 28 :
			Palabra = "Pulgada";
			RomboId01.GetComponent<Renderer>().material = LetraA;
			RomboId02.GetComponent<Renderer>().material = LetraD;
			RomboId03.GetComponent<Renderer>().material = LetraG;
			RomboId04.GetComponent<Renderer>().material = LetraL;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraP;
			RomboId07.GetComponent<Renderer>().material = LetraU;
			break;
		case 29 :
			Palabra = "Ventana";
			RomboId01.GetComponent<Renderer>().material = LetraV;
			RomboId02.GetComponent<Renderer>().material = LetraT;
			RomboId03.GetComponent<Renderer>().material = LetraE;
			RomboId04.GetComponent<Renderer>().material = LetraN;
			RomboId05.GetComponent<Renderer>().material = LetraA;
			RomboId06.GetComponent<Renderer>().material = LetraA;
			RomboId07.GetComponent<Renderer>().material = LetraN;
			break;
		case 30 :
			Palabra = "Asustar";
			RomboId01.GetComponent<Renderer>().material = LetraT;
			RomboId02.GetComponent<Renderer>().material = LetraS;
			RomboId03.GetComponent<Renderer>().material = LetraA;
			RomboId04.GetComponent<Renderer>().material = LetraS;
			RomboId05.GetComponent<Renderer>().material = LetraU;
			RomboId06.GetComponent<Renderer>().material = LetraR;
			RomboId07.GetComponent<Renderer>().material = LetraA;
			break;
		}
	

	}
	
	// Update is called once per frame
	void Update () {
		Vidas = PlayerPrefs.GetInt ("Vidas");
	}
}
