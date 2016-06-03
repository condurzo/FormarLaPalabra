using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour {
	public float Tiempo;
	public AnimacionBolita bolita;
	public AudioClip sonido;
	public bool activeSonido;
	public bool Termino;

	void Awake(){
		Termino = false;
		bolita.enabled = true;
	}

	void Start(){

		if(PlayerPrefs.GetInt("UnaVezMonedas")==0){
			PlayerPrefs.SetInt ("Desblo-Nivel1-Ver1", 1);
			PlayerPrefs.SetInt("Monedas",20);
			PlayerPrefs.SetInt ("Vidas", 5);
			PlayerPrefs.SetInt("UnaVezMonedas",1);
		}

	

		GetComponent<AudioSource>().clip = sonido;

//		if(PlayerPrefs.GetInt("Setear")==0){
//			PlayerPrefs.SetInt("Mute",1);
//			PlayerPrefs.SetInt("Setear",1);
//		}
	}

	void Update () {
		if (Termino) {
			if (AnimacionBolita.currentPathPercent >= 1) {
				bolita.enabled = false;
			}
		}
		if( Tiempo >= 1.3f){
			Termino = true;
			if(!GetComponent<AudioSource>().isPlaying){
				GetComponent<AudioSource>().Play();
			}
		}

		Tiempo += Time.deltaTime;
		if( Tiempo >= 3.5f){
			
			System.GC.Collect();
			System.GC.WaitForPendingFinalizers();
			Resources.UnloadUnusedAssets();

			if (PlayerPrefs.GetInt ("Tutorial") == 0) {
				Application.LoadLevel ("Tutorial");
			} else {
				Application.LoadLevel ("SelectorMundos");
			}
		}
	}
}
