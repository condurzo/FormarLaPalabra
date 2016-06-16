using UnityEngine;
using System.Collections;

public class Modo4Puntos : MonoBehaviour {
	
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
	public string Id8;
	public string Id9;
	public string Id10;

	public bool id1Bool;
	public bool id2Bool;
	public bool id3Bool;
	public bool id4Bool;
	public bool id5Bool;
	public bool id6Bool;
	public bool id7Bool;
	public bool id8Bool;
	public bool id9Bool;
	public bool id10Bool;

	public int Nivel;

	public bool Letra1;
	public bool Letra2;
	public bool Letra3;
	public bool Letra4;
	public bool Letra5;
	public bool Letra6;
	public bool Letra7;
	public bool Letra8;
	public bool Letra9;
	public bool Letra10;

	public GameObject Letra1GO;
	public GameObject Letra2GO;
	public GameObject Letra3GO;
	public GameObject Letra4GO;
	public GameObject Letra5GO;
	public GameObject Letra6GO;
	public GameObject Letra7GO;
	public GameObject Letra8GO;
	public GameObject Letra9GO;
	public GameObject Letra10GO;

	public GameObject Letra1Mat;
	public GameObject Letra2Mat;
	public GameObject Letra3Mat;
	public GameObject Letra4Mat;
	public GameObject Letra5Mat;
	public GameObject Letra6Mat;
	public GameObject Letra7Mat;
	public GameObject Letra8Mat;
	public GameObject Letra9Mat;
	public GameObject Letra10Mat;

	public Collider Letra1Coll;
	public Collider Letra2Coll;
	public Collider Letra3Coll;
	public Collider Letra4Coll;
	public Collider Letra5Coll;
	public Collider Letra6Coll;
	public Collider Letra7Coll;
	public Collider Letra8Coll;
	public Collider Letra9Coll;
	public Collider Letra10Coll;

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
	public GameObject Rombo9;
	public GameObject Rombo10;

	public Material Rombo1Comun;
	public Material Rombo2Comun;
	public Material Rombo3Comun;
	public Material Rombo4Comun;
	public Material Rombo5Comun;
	public Material Rombo6Comun;
	public Material Rombo7Comun;
	public Material Rombo8Comun;
	public Material Rombo9Comun;
	public Material Rombo10Comun;


	public Material Rombo1Alpha;
	public Material Rombo2Alpha;
	public Material Rombo3Alpha;
	public Material Rombo4Alpha;
	public Material Rombo5Alpha;
	public Material Rombo6Alpha;
	public Material Rombo7Alpha;
	public Material Rombo8Alpha;
	public Material Rombo9Alpha;
	public Material Rombo10Alpha;

	public int MonedasTemp;
	public int MonedasWin;

	public AudioClip PerdisteAudio;
	public AudioClip GanasteAudio;
	public AudioClip TocoRombo;

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
		id9Bool = false;
		id10Bool = false;
		Final = "";

		Nivel = PlayerPrefs.GetInt("level4");
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
			Id9="9";
			Id10="10";
			FinalTemp = "10736985214";
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
			Id9="9";
			Id10="10";
			FinalTemp = "58412369107";
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
			Id9="9";
			Id10="10";
			FinalTemp = "37610984521";
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
			Id9="9";
			Id10="10";
			FinalTemp = "25637109841";
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
			Id9="9";
			Id10="10";
			FinalTemp = "12376548910";
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
			Id9="9";
			Id10="10";
			FinalTemp = "85412376910";
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
			Id9="9";
			Id10="10";
			FinalTemp = "67109845123";
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
			Id9="9";
			Id10="10";
			FinalTemp = "23710698415";
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
			Id9="9";
			Id10="10";
			FinalTemp = "12376109845";
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
			Id9="9";
			Id10="10";
			FinalTemp = "52148910736";
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
			Id9="9";
			Id10="10";
			FinalTemp = "32514891076";
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
			Id9="9";
			Id10="10";
			FinalTemp = "65489107321";
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
			Id9="9";
			Id10="10";
			FinalTemp = "91073625148";
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
			Id9="9";
			Id10="10";
			FinalTemp = "23651489107";
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
			Id9="9";
			Id10="10";
			FinalTemp = "95841236710";
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
			Id9="9";
			Id10="10";
			FinalTemp = "61073215489";
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
			Id9="9";
			Id10="10";
			FinalTemp = "98412371065";
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
			Id9="9";
			Id10="10";
			FinalTemp = "15263710984";
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
			Id9="9";
			Id10="10";
			FinalTemp = "91073214856";
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
			Id9="9";
			Id10="10";
			FinalTemp = "10673259841";
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
			Id9="9";
			Id10="10";
			FinalTemp = "12548961073";
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
			Id9="9";
			Id10="10";
			FinalTemp = "56710984123";
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
			Id9="9";
			Id10="10";
			FinalTemp = "15263710984";
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
			Id9="9";
			Id10="10";
			FinalTemp = "56984123710";
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
			Id9="9";
			Id10="10";
			FinalTemp = "73625148910";
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
			Id9="9";
			Id10="10";
			FinalTemp = "10732145698";
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
			Id9="9";
			Id10="10";
			FinalTemp = "89541236710";
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
			Id9="9";
			Id10="10";
			FinalTemp = "84123710965";
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
			Id9="9";
			Id10="10";
			FinalTemp = "65412371098";
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
			Id9="9";
			Id10="10";
			FinalTemp = "10673251489";
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
		if(SumadorLetras == 9){
			Letra9GO.SetActive(true);
			Letra9GO.GetComponent<Renderer>().material = LastMaterial.GetComponent<Renderer>().material;
		}
		if(SumadorLetras == 10){
			Letra10GO.SetActive(true);
			Letra10GO.GetComponent<Renderer>().material = LastMaterial.GetComponent<Renderer>().material;
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
				Letra9Coll.enabled = true;
				Letra10Coll.enabled = true;
				if(id1Bool && id2Bool && id3Bool && id4Bool && id5Bool && id6Bool && id7Bool && id8Bool && id9Bool && id10Bool){
					if(Final == FinalTemp){
						Debug.Log("Ganaste");
						int Level = PlayerPrefs.GetInt ("level4");
						Level++;
						PlayerPrefs.SetInt ("level4", Level);
						if (PlayerPrefs.GetInt ("level4") == 30) {
							PlayerPrefs.SetInt ("Stop-Nivel4-Ver1", 1);
							PlayerPrefs.SetInt ("Desblo-Nivel4-Ver1", 0);
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
						Letra8GO.SetActive(false);
						Letra9GO.SetActive(false);
						Letra10GO.SetActive(false);
						Letra1Coll.enabled = false;
						Letra2Coll.enabled = false;
						Letra3Coll.enabled = false;
						Letra4Coll.enabled = false;
						Letra5Coll.enabled = false;
						Letra6Coll.enabled = false;
						Letra7Coll.enabled = false;
						Letra8Coll.enabled = false;
						Letra9Coll.enabled = false;
						Letra10Coll.enabled = false;
						SumadorLetras = 0;
						Rombo1.GetComponent<Renderer>().material = Rombo1Comun;
						Rombo2.GetComponent<Renderer>().material = Rombo2Comun;
						Rombo3.GetComponent<Renderer>().material = Rombo3Comun;
						Rombo4.GetComponent<Renderer>().material = Rombo4Comun;
						Rombo5.GetComponent<Renderer>().material = Rombo5Comun;
						Rombo6.GetComponent<Renderer>().material = Rombo6Comun;
						Rombo7.GetComponent<Renderer>().material = Rombo7Comun;
						Rombo8.GetComponent<Renderer>().material = Rombo8Comun;
						Rombo9.GetComponent<Renderer>().material = Rombo9Comun;
						Rombo10.GetComponent<Renderer>().material = Rombo10Comun;
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
				id9Bool = false;
				id10Bool = false;
				Final = "";
				Letra1GO.SetActive(false);
				Letra2GO.SetActive(false);
				Letra3GO.SetActive(false);
				Letra4GO.SetActive(false);
				Letra5GO.SetActive(false);
				Letra6GO.SetActive(false);
				Letra7GO.SetActive(false);
				Letra8GO.SetActive(false);
				Letra9GO.SetActive(false);
				Letra10GO.SetActive(false);
				SumadorLetras = 0;
				Letra1Coll.enabled = false;
				Letra2Coll.enabled = false;
				Letra3Coll.enabled = false;
				Letra4Coll.enabled = false;
				Letra5Coll.enabled = false;
				Letra6Coll.enabled = false;
				Letra7Coll.enabled = false;
				Letra8Coll.enabled = false;
				Letra9Coll.enabled = false;
				Letra10Coll.enabled = false;
				Rombo1.GetComponent<Renderer>().material = Rombo1Comun;
				Rombo2.GetComponent<Renderer>().material = Rombo2Comun;
				Rombo3.GetComponent<Renderer>().material = Rombo3Comun;
				Rombo4.GetComponent<Renderer>().material = Rombo4Comun;
				Rombo5.GetComponent<Renderer>().material = Rombo5Comun;
				Rombo6.GetComponent<Renderer>().material = Rombo6Comun;
				Rombo7.GetComponent<Renderer>().material = Rombo7Comun;
				Rombo8.GetComponent<Renderer>().material = Rombo8Comun;
				Rombo9.GetComponent<Renderer>().material = Rombo9Comun;
				Rombo10.GetComponent<Renderer>().material = Rombo10Comun;
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
					GetComponent<AudioSource>().clip = TocoRombo;
					if (!GetComponent<AudioSource> ().isPlaying) {
						GetComponent<AudioSource> ().Play ();
					}
					id1Bool=true;

				}
			}
			if(!id2Bool){
				if(hit.collider.name == "ID02"){
					Final += Id2;
					Rombo2.GetComponent<Renderer>().material = Rombo2Alpha;
					LastMaterial.GetComponent<Renderer>().material = Letra2Mat.GetComponent<Renderer>().material;
					SumadorLetras ++;
					GetComponent<AudioSource>().clip = TocoRombo;
					if (!GetComponent<AudioSource> ().isPlaying) {
						GetComponent<AudioSource> ().Play ();
					}
					id2Bool = true;
				}
			}
			if(!id3Bool){
				if(hit.collider.name == "ID03"){
					Final += Id3;
					Rombo3.GetComponent<Renderer>().material = Rombo3Alpha;
					LastMaterial.GetComponent<Renderer>().material = Letra3Mat.GetComponent<Renderer>().material;
					SumadorLetras ++;
					GetComponent<AudioSource>().clip = TocoRombo;
					if (!GetComponent<AudioSource> ().isPlaying) {
						GetComponent<AudioSource> ().Play ();
					}
					id3Bool = true;
				}
			}
			if(!id4Bool){
				if(hit.collider.name == "ID04"){
					Final += Id4;
					Rombo4.GetComponent<Renderer>().material = Rombo4Alpha;
					LastMaterial.GetComponent<Renderer>().material = Letra4Mat.GetComponent<Renderer>().material;
					SumadorLetras ++;
					GetComponent<AudioSource>().clip = TocoRombo;
					if (!GetComponent<AudioSource> ().isPlaying) {
						GetComponent<AudioSource> ().Play ();
					}
					id4Bool = true;
				}
			}
			if(!id5Bool){
				if(hit.collider.name == "ID05"){
					Final += Id5;
					Rombo5.GetComponent<Renderer>().material = Rombo5Alpha;
					LastMaterial.GetComponent<Renderer>().material = Letra5Mat.GetComponent<Renderer>().material;
					SumadorLetras ++;
					GetComponent<AudioSource>().clip = TocoRombo;
					if (!GetComponent<AudioSource> ().isPlaying) {
						GetComponent<AudioSource> ().Play ();
					}
					id5Bool = true;
				}
			}
			if(!id6Bool){
				if(hit.collider.name == "ID06"){
					Final += Id6;
					Rombo6.GetComponent<Renderer>().material = Rombo6Alpha;
					LastMaterial.GetComponent<Renderer>().material = Letra6Mat.GetComponent<Renderer>().material;
					SumadorLetras ++;
					GetComponent<AudioSource>().clip = TocoRombo;
					if (!GetComponent<AudioSource> ().isPlaying) {
						GetComponent<AudioSource> ().Play ();
					}
					id6Bool = true;
				}
			}
			if(!id7Bool){
				if(hit.collider.name == "ID07"){
					Final += Id7;
					Rombo7.GetComponent<Renderer>().material = Rombo7Alpha;
					LastMaterial.GetComponent<Renderer>().material = Letra7Mat.GetComponent<Renderer>().material;
					SumadorLetras ++;
					GetComponent<AudioSource>().clip = TocoRombo;
					if (!GetComponent<AudioSource> ().isPlaying) {
						GetComponent<AudioSource> ().Play ();
					}
					id7Bool = true;
				}
			}
			if(!id8Bool){
				if(hit.collider.name == "ID08"){
					Final += Id8;
					Rombo8.GetComponent<Renderer>().material = Rombo8Alpha;
					LastMaterial.GetComponent<Renderer>().material = Letra8Mat.GetComponent<Renderer>().material;
					SumadorLetras ++;
					GetComponent<AudioSource>().clip = TocoRombo;
					if (!GetComponent<AudioSource> ().isPlaying) {
						GetComponent<AudioSource> ().Play ();
					}
					id8Bool = true;
				}
			}
			if(!id9Bool){
				if(hit.collider.name == "ID09"){
					Final += Id9;
					Rombo9.GetComponent<Renderer>().material = Rombo9Alpha;
					LastMaterial.GetComponent<Renderer>().material = Letra9Mat.GetComponent<Renderer>().material;
					SumadorLetras ++;
					GetComponent<AudioSource>().clip = TocoRombo;
					if (!GetComponent<AudioSource> ().isPlaying) {
						GetComponent<AudioSource> ().Play ();
					}
					id9Bool = true;
				}
			}
			if(!id10Bool){
				if(hit.collider.name == "ID10"){
					Final += Id10;
					Rombo10.GetComponent<Renderer>().material = Rombo10Alpha;
					LastMaterial.GetComponent<Renderer>().material = Letra10Mat.GetComponent<Renderer>().material;
					SumadorLetras ++;
					GetComponent<AudioSource>().clip = TocoRombo;
					if (!GetComponent<AudioSource> ().isPlaying) {
						GetComponent<AudioSource> ().Play ();
					}
					id10Bool = true;
				}
			}
			//Debug.DrawLine(ray.origin, hit.point);
		}
	}

}