﻿using UnityEngine;
using System.Collections;

public class Modo2Puntos : MonoBehaviour {

	public GameObject MenuVictoria;
	public static bool jugar;

	public string Final;
	public string FinalTemp;
	public string Id1;
	public string Id2;
	public string Id3;
	public string Id4;
	public string Id5;
	public string Id6;
	public string Id7;
	public string Id8;

	public bool id1Bool;
	public bool id2Bool;
	public bool id3Bool;
	public bool id4Bool;
	public bool id5Bool;
	public bool id6Bool;
	public bool id7Bool;
	public bool id8Bool;

	public int Nivel;

	public bool Letra1;
	public bool Letra2;
	public bool Letra3;
	public bool Letra4;
	public bool Letra5;
	public bool Letra6;
	public bool Letra7;
	public bool Letra8;

	public GameObject Letra1GO;
	public GameObject Letra2GO;
	public GameObject Letra3GO;
	public GameObject Letra4GO;
	public GameObject Letra5GO;
	public GameObject Letra6GO;
	public GameObject Letra7GO;
	public GameObject Letra8GO;

	public GameObject Letra1Mat;
	public GameObject Letra2Mat;
	public GameObject Letra3Mat;
	public GameObject Letra4Mat;
	public GameObject Letra5Mat;
	public GameObject Letra6Mat;
	public GameObject Letra7Mat;
	public GameObject Letra8Mat;

	public Collider Letra1Coll;
	public Collider Letra2Coll;
	public Collider Letra3Coll;
	public Collider Letra4Coll;
	public Collider Letra5Coll;
	public Collider Letra6Coll;
	public Collider Letra7Coll;
	public Collider Letra8Coll;

	public int SumadorLetras;

	public GameObject LastMaterial;


	public GameObject Rombo1;
	public GameObject Rombo2;
	public GameObject Rombo3;
	public GameObject Rombo4;
	public GameObject Rombo5;
	public GameObject Rombo6;
	public GameObject Rombo7;
	public GameObject Rombo8;

	public Material Rombo1Comun;
	public Material Rombo2Comun;
	public Material Rombo3Comun;
	public Material Rombo4Comun;
	public Material Rombo5Comun;
	public Material Rombo6Comun;
	public Material Rombo7Comun;
	public Material Rombo8Comun;


	public Material Rombo1Alpha;
	public Material Rombo2Alpha;
	public Material Rombo3Alpha;
	public Material Rombo4Alpha;
	public Material Rombo5Alpha;
	public Material Rombo6Alpha;
	public Material Rombo7Alpha;
	public Material Rombo8Alpha;

	public int MonedasTemp;
	public int MonedasWin;

	public AudioClip PerdisteAudio;


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
		id8Bool = false;
		Final = "";

		Nivel = PlayerPrefs.GetInt("level2");
		switch (Nivel){
		case 1 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "32145876";
			break;
		case 2 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "53214678";
			break;
		case 3 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "23587641";
			break;
		case 4 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "41235876";
			break;
		case 5 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "58764123";
			break;
		case 6 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "76412358";
			break;
		case 7 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "85764123";
			break;
		case 8 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "35214678";
			break;
		case 9 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "85321476";
			break;
		case 10 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "12354678";
			break;
		case 11 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "23587641";
			break;
		case 12 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "32145876";
			break;
		case 13 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "14678532";
			break;
		case 14 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "85321476";
			break;
		case 15 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "41235876";
			break;
		case 16 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "76412358";
			break;
		case 17 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "64785321";
			break;
		case 18 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "85764123";
			break;
		case 19 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "23587641";
			break;
		case 20 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "12354678";
			break;
		case 21 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "23587641";
			break;
		case 22 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "78532146";
			break;
		case 23 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "21467853";
			break;
		case 24 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "46785321";
			break;
		case 25 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "41235678";
			break;
		case 26 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "78532146";
			break;
		case 27 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "76412358";
			break;
		case 28 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "35214678";
			break;
		case 29 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "85764123";
			break;
		case 30 :
			Id1="1";
			Id2="2";
			Id3="3";
			Id4="4";
			Id5="5";
			Id6="6";
			Id7="7";
			Id8="8";
			FinalTemp = "14235876";
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
		if(SumadorLetras == 8){
			Letra8GO.SetActive(true);
			Letra8GO.GetComponent<Renderer>().material = LastMaterial.GetComponent<Renderer>().material;
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
				Letra8Coll.enabled = true;
				if(id1Bool && id2Bool && id3Bool && id4Bool && id5Bool && id6Bool && id7Bool && id8Bool){
					if(Final == FinalTemp){
						Debug.Log("Ganaste");
						MonedasTemp = PlayerPrefs.GetInt("Monedas");
						MonedasTemp += 1;
						PlayerPrefs.SetInt("Monedas",MonedasTemp);
						jugar = false;
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
						Letra8GO.SetActive(false);
						Letra1Coll.enabled = false;
						Letra2Coll.enabled = false;
						Letra3Coll.enabled = false;
						Letra4Coll.enabled = false;
						Letra5Coll.enabled = false;
						Letra6Coll.enabled = false;
						Letra7Coll.enabled = false;
						Letra8Coll.enabled = false;
						SumadorLetras = 0;
						Rombo1.GetComponent<Renderer>().material = Rombo1Comun;
						Rombo2.GetComponent<Renderer>().material = Rombo2Comun;
						Rombo3.GetComponent<Renderer>().material = Rombo3Comun;
						Rombo4.GetComponent<Renderer>().material = Rombo4Comun;
						Rombo5.GetComponent<Renderer>().material = Rombo5Comun;
						Rombo6.GetComponent<Renderer>().material = Rombo6Comun;
						Rombo7.GetComponent<Renderer>().material = Rombo7Comun;
						Rombo8.GetComponent<Renderer>().material = Rombo8Comun;
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
				id8Bool = false;
				Final = "";
				Letra1GO.SetActive(false);
				Letra2GO.SetActive(false);
				Letra3GO.SetActive(false);
				Letra4GO.SetActive(false);
				Letra5GO.SetActive(false);
				Letra6GO.SetActive(false);
				Letra7GO.SetActive(false);
				Letra8GO.SetActive(false);
				SumadorLetras = 0;
				Letra1Coll.enabled = false;
				Letra2Coll.enabled = false;
				Letra3Coll.enabled = false;
				Letra4Coll.enabled = false;
				Letra5Coll.enabled = false;
				Letra6Coll.enabled = false;
				Letra7Coll.enabled = false;
				Letra8Coll.enabled = false;
				Rombo1.GetComponent<Renderer>().material = Rombo1Comun;
				Rombo2.GetComponent<Renderer>().material = Rombo2Comun;
				Rombo3.GetComponent<Renderer>().material = Rombo3Comun;
				Rombo4.GetComponent<Renderer>().material = Rombo4Comun;
				Rombo5.GetComponent<Renderer>().material = Rombo5Comun;
				Rombo6.GetComponent<Renderer>().material = Rombo6Comun;
				Rombo7.GetComponent<Renderer>().material = Rombo7Comun;
				Rombo8.GetComponent<Renderer>().material = Rombo8Comun;
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
			if(!id8Bool){
				if(hit.collider.name == "ID08"){
					Final += Id8;
					Rombo8.GetComponent<Renderer>().material = Rombo8Alpha;
					LastMaterial.GetComponent<Renderer>().material = Letra8Mat.GetComponent<Renderer>().material;
					SumadorLetras ++;
					id8Bool = true;
				}
			}
			//Debug.DrawLine(ray.origin, hit.point);
		}
	}

}