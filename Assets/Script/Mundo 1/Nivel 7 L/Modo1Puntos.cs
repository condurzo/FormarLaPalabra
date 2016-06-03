﻿using UnityEngine;
using System.Collections;

public class Modo1Puntos : MonoBehaviour {

	public int mostrador;
	public admobscript admob;

	public GameObject MenuVictoria;
	public static bool jugar;
	public static bool Victoria;

	public GameObject GUI1;
	public GameObject GUI2;
	public GameObject GUI3;
	public GameObject GUI4;
	public GameObject GUI5;

	public string Final;
	public string FinalTemp;
	public string Id1;
	public string Id2;
	public string Id3;
	public string Id4;
	public string Id5;
	public string Id6;
	public string Id7;

	public bool id1Bool;
	public bool id2Bool;
	public bool id3Bool;
	public bool id4Bool;
	public bool id5Bool;
	public bool id6Bool;
	public bool id7Bool;

	public int Nivel;

	public bool Letra1;
	public bool Letra2;
	public bool Letra3;
	public bool Letra4;
	public bool Letra5;
	public bool Letra6;
	public bool Letra7;

	public GameObject Letra1GO;
	public GameObject Letra2GO;
	public GameObject Letra3GO;
	public GameObject Letra4GO;
	public GameObject Letra5GO;
	public GameObject Letra6GO;
	public GameObject Letra7GO;

	public GameObject Letra1Mat;
	public GameObject Letra2Mat;
	public GameObject Letra3Mat;
	public GameObject Letra4Mat;
	public GameObject Letra5Mat;
	public GameObject Letra6Mat;
	public GameObject Letra7Mat;

	public Collider Letra1Coll;
	public Collider Letra2Coll;
	public Collider Letra3Coll;
	public Collider Letra4Coll;
	public Collider Letra5Coll;
	public Collider Letra6Coll;
	public Collider Letra7Coll;


	public int SumadorLetras;

	public GameObject LastMaterial;


	public GameObject Rombo1;
	public GameObject Rombo2;
	public GameObject Rombo3;
	public GameObject Rombo4;
	public GameObject Rombo5;
	public GameObject Rombo6;
	public GameObject Rombo7;

	public Material Rombo1Comun;
	public Material Rombo2Comun;
	public Material Rombo3Comun;
	public Material Rombo4Comun;
	public Material Rombo5Comun;
	public Material Rombo6Comun;
	public Material Rombo7Comun;


	public Material Rombo1Alpha;
	public Material Rombo2Alpha;
	public Material Rombo3Alpha;
	public Material Rombo4Alpha;
	public Material Rombo5Alpha;
	public Material Rombo6Alpha;
	public Material Rombo7Alpha;

	public int MonedasTemp;
	public int MonedasWin;

	public AudioClip PerdisteAudio;
	public AudioClip GanasteAudio;


	void Start(){

		SumadorLetras = 0;

		jugar = true;

		id1Bool = false;
		id2Bool = false;
		id3Bool = false;
		id4Bool = false;
		id5Bool = false;
		id6Bool = false;
		id7Bool = false;
		Final = "";

		Nivel = PlayerPrefs.GetInt("level");
		switch (Nivel){
		case 1 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "3647521";
			break;
		case 2 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "5763124";
			break;
		case 3 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "3467521";
			break;
		case 4 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "3125476";
			break;
		case 5 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "3125764";
			break;
		case 6 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "7631452";
			break;
		case 7 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "1342576";
			break;
		case 8 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "6312574";
			break;
		case 9 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "2547631";
			break;
		case 10 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "3412576";
			break;
		case 11 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "3142576";
			break;
		case 12 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "4257631";
			break;
		case 13 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "2457631";
			break;
		case 14 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "1243675";
			break;
		case 15 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "3647521";
			break;
		case 16 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "1245763";
			break;
		case 17 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "5476312";
			break;
		case 18 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "7524631";
			break;
		case 19 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "2457631";
			break;
		case 20 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "3142576";
			break;
		case 21 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "4675213";
			break;
		case 22 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "5476312";
			break;
		case 23 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "7546312";
			break;
		case 24 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "2574136";
			break;
		case 25 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "3146752";
			break;
		case 26 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "7643125";
			break;
		case 27 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "5247631";
			break;
		case 28 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "6743125";
			break;
		case 29 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "1342576";
			break;
		case 30 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			FinalTemp = "7452136";
			break;

	}

	}

	void Update(){


		if(SumadorLetras == 1){
			Letra1GO.SetActive(true);
			Letra1GO.GetComponent<Renderer>().material = LastMaterial.GetComponent<Renderer>().material;

		}

		if(SumadorLetras == 2){
			Letra2GO.SetActive(true);
			Letra2GO.GetComponent<Renderer>().material = LastMaterial.GetComponent<Renderer>().material;
		}
		if(SumadorLetras == 3){
			Letra3GO.SetActive(true);
			Letra3GO.GetComponent<Renderer>().material = LastMaterial.GetComponent<Renderer>().material;
		}
		if(SumadorLetras == 4){
			Letra4GO.SetActive(true);
			Letra4GO.GetComponent<Renderer>().material = LastMaterial.GetComponent<Renderer>().material;
		}
		if(SumadorLetras == 5){
			Letra5GO.SetActive(true);
			Letra5GO.GetComponent<Renderer>().material = LastMaterial.GetComponent<Renderer>().material;
		}
		if(SumadorLetras == 6){
			Letra6GO.SetActive(true);
			Letra6GO.GetComponent<Renderer>().material = LastMaterial.GetComponent<Renderer>().material;
		}
		if(SumadorLetras == 7){
			Letra7GO.SetActive(true);
			Letra7GO.GetComponent<Renderer>().material = LastMaterial.GetComponent<Renderer>().material;
		}


		if(jugar){
			if(!FingerEventsSamplePart2.Levanto){
					Letra1Coll.enabled = true;
					Letra2Coll.enabled = true;
					Letra3Coll.enabled = true;
					Letra4Coll.enabled = true;
					Letra5Coll.enabled = true;
					Letra6Coll.enabled = true;
					Letra7Coll.enabled = true;
				if(id1Bool && id2Bool && id3Bool && id4Bool && id5Bool && id6Bool && id7Bool){
					if(Final == FinalTemp){
						Debug.Log("Ganaste");
						int Level = PlayerPrefs.GetInt ("level");
						Level++;
						PlayerPrefs.SetInt ("level", Level);
						if (PlayerPrefs.GetInt ("level") == 30) {
							PlayerPrefs.SetInt ("Desblo-Nivel2-Ver1", 1);
							PlayerPrefs.SetInt ("Stop-Nivel1-Ver1", 1);
							PlayerPrefs.SetInt ("Desblo-Nivel1-Ver1", 0);
						}
						Modo1Puntos.Victoria = false;
						CountdownTimer_CSHARP.TerminoPartida = false;
						MonedasTemp = PlayerPrefs.GetInt("Monedas");
						MonedasTemp += 2;
						PlayerPrefs.SetInt("Monedas",MonedasTemp);
						mostrador = PlayerPrefs.GetInt ("MostrarInterstitial");
						if (mostrador >= 5) {
							admob.ShowInterstitial ();
							PlayerPrefs.SetInt("MostrarInterstitial", 0);
						}
						jugar = false;
						GUI1.SetActive (false);
						GUI2.SetActive (false);
						GUI3.SetActive (false);
						GUI4.SetActive (false);
						GUI5.SetActive (false);
						CountdownTimer_CSHARP.TerminoPartida = true;
						Victoria = true;
 						GetComponent<AudioSource>().clip = GanasteAudio;
						if (!GetComponent<AudioSource> ().isPlaying) {
							GetComponent<AudioSource> ().Play ();
						}
						MenuVictoria.SetActive(true);
					}else{
						GetComponent<AudioSource>().clip = PerdisteAudio;
						if(!GetComponent<AudioSource>().isPlaying){
							GetComponent<AudioSource>().Play();
							}

							Letra1GO.SetActive(false);
							Letra2GO.SetActive(false);
							Letra3GO.SetActive(false);
							Letra4GO.SetActive(false);
							Letra5GO.SetActive(false);
							Letra6GO.SetActive(false);
							Letra7GO.SetActive(false);
							Letra1Coll.enabled = false;
							Letra2Coll.enabled = false;
							Letra3Coll.enabled = false;
							Letra4Coll.enabled = false;
							Letra5Coll.enabled = false;
							Letra6Coll.enabled = false;
							Letra7Coll.enabled = false;
							SumadorLetras = 0;
							Rombo1.GetComponent<Renderer>().material = Rombo1Comun;
							Rombo2.GetComponent<Renderer>().material = Rombo2Comun;
							Rombo3.GetComponent<Renderer>().material = Rombo3Comun;
							Rombo4.GetComponent<Renderer>().material = Rombo4Comun;
							Rombo5.GetComponent<Renderer>().material = Rombo5Comun;
							Rombo6.GetComponent<Renderer>().material = Rombo6Comun;
							Rombo7.GetComponent<Renderer>().material = Rombo7Comun;
							//Debug.Log("Perdiste");
					
					}
				}
			}
		}


		if(jugar){
			if(FingerEventsSamplePart2.Levanto){
				if(SumadorLetras >0){
					GetComponent<AudioSource>().clip = PerdisteAudio;
					if(!GetComponent<AudioSource>().isPlaying){
						GetComponent<AudioSource>().Play();
					}
				}
				id1Bool = false;
				id2Bool = false;
				id3Bool = false;
				id4Bool = false;
				id5Bool = false;
				id6Bool = false;
				id7Bool = false;
				Final = "";
				Letra1GO.SetActive(false);
				Letra2GO.SetActive(false);
				Letra3GO.SetActive(false);
				Letra4GO.SetActive(false);
				Letra5GO.SetActive(false);
				Letra6GO.SetActive(false);
				Letra7GO.SetActive(false);
				SumadorLetras = 0;
				Letra1Coll.enabled = false;
				Letra2Coll.enabled = false;
				Letra3Coll.enabled = false;
				Letra4Coll.enabled = false;
				Letra5Coll.enabled = false;
				Letra6Coll.enabled = false;
				Letra7Coll.enabled = false;
				Rombo1.GetComponent<Renderer>().material = Rombo1Comun;
				Rombo2.GetComponent<Renderer>().material = Rombo2Comun;
				Rombo3.GetComponent<Renderer>().material = Rombo3Comun;
				Rombo4.GetComponent<Renderer>().material = Rombo4Comun;
				Rombo5.GetComponent<Renderer>().material = Rombo5Comun;
				Rombo6.GetComponent<Renderer>().material = Rombo6Comun;
				Rombo7.GetComponent<Renderer>().material = Rombo7Comun;
			}
		}



		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit, 100)) {
			if(!id1Bool){
				if(hit.collider.name == "ID01"){
					Final += Id1;
					Rombo1.GetComponent<Renderer>().material = Rombo1Alpha;
					LastMaterial.GetComponent<Renderer>().material = Letra1Mat.GetComponent<Renderer>().material;
					SumadorLetras ++;
					id1Bool=true;

				}
			}
			if(!id2Bool){
				if(hit.collider.name == "ID02"){
					Final += Id2;
					Rombo2.GetComponent<Renderer>().material = Rombo2Alpha;
					LastMaterial.GetComponent<Renderer>().material = Letra2Mat.GetComponent<Renderer>().material;
					SumadorLetras ++;
					id2Bool = true;
				}
			}
			if(!id3Bool){
				if(hit.collider.name == "ID03"){
					Final += Id3;
					Rombo3.GetComponent<Renderer>().material = Rombo3Alpha;
					LastMaterial.GetComponent<Renderer>().material = Letra3Mat.GetComponent<Renderer>().material;
					SumadorLetras ++;
					id3Bool = true;
				}
			}
			if(!id4Bool){
				if(hit.collider.name == "ID04"){
					Final += Id4;
					Rombo4.GetComponent<Renderer>().material = Rombo4Alpha;
					LastMaterial.GetComponent<Renderer>().material = Letra4Mat.GetComponent<Renderer>().material;
					SumadorLetras ++;
					id4Bool = true;
				}
			}
			if(!id5Bool){
				if(hit.collider.name == "ID05"){
					Final += Id5;
					Rombo5.GetComponent<Renderer>().material = Rombo5Alpha;
					LastMaterial.GetComponent<Renderer>().material = Letra5Mat.GetComponent<Renderer>().material;
					SumadorLetras ++;
					id5Bool = true;
				}
			}
			if(!id6Bool){
				if(hit.collider.name == "ID06"){
					Final += Id6;
					Rombo6.GetComponent<Renderer>().material = Rombo6Alpha;
					LastMaterial.GetComponent<Renderer>().material = Letra6Mat.GetComponent<Renderer>().material;
					SumadorLetras ++;
					id6Bool = true;
				}
			}
			if(!id7Bool){
				if(hit.collider.name == "ID07"){
					Final += Id7;
					Rombo7.GetComponent<Renderer>().material = Rombo7Alpha;
					LastMaterial.GetComponent<Renderer>().material = Letra7Mat.GetComponent<Renderer>().material;
					SumadorLetras ++;
					id7Bool = true;
				}
			}
			//Debug.DrawLine(ray.origin, hit.point);
		}
	}

}