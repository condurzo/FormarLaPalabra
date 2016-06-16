using UnityEngine;
using System.Collections;

public class CountdownTimer_CSHARP : MonoBehaviour {
	public float Seconds = 5;
	public float Minutes = 0;

	public static float SegundosPuntos;
	public static float MinutosPuntos;

	public static bool TerminoPartida;
	public GameObject Perdiste;
	public GameObject GUI1;
	public GameObject GUI2;
	public GameObject GUI3;
	public GameObject GUI4;
	public GameObject GUI5;

	public bool tiempo;
	public bool ActivoTiempo;
	public GameObject Reloj;

	public bool Perdio;
	public int Vidas;

	public AudioClip RelojAudio;


	void Start(){
		GetComponent<AudioSource>().clip = RelojAudio;
		GetComponent<AudioSource>().Play();
		if (PlayerPrefs.GetInt ("Sounds") == 0) {
			GetComponent<AudioSource> ().volume = 0.4f;
		}
	}

	void Update(){
		



		if (!TerminoPartida) {
			SegundosPuntos = Seconds;
			MinutosPuntos = Minutes;

			if (Seconds <= 0) {
				Seconds = 59;
				if (Minutes >= 1) {
					Minutes--;
				} else {
					Minutes = 0;
					Seconds = 0;
					GameObject.Find ("TimerText").GetComponent<TextMesh> ().text = Minutes.ToString ("f0") + ":0" + Seconds.ToString ("f0");
				}
			} else {
				Seconds -= Time.deltaTime;
			}

			if (Mathf.Round (Seconds) <= 9) {
				GameObject.Find ("TimerText").GetComponent<TextMesh> ().text = Minutes.ToString ("f0") + ":0" + Seconds.ToString ("f0");
			} else {
				GameObject.Find ("TimerText").GetComponent<TextMesh> ().text = Minutes.ToString ("f0") + ":" + Seconds.ToString ("f0");
			}

			if ((Seconds == 0)&&(Minutes == 0)) {
				Vidas = PlayerPrefs.GetInt ("Vidas");
				Perdio = true;
				TerminoPartida = true;
				PlayerPrefs.SetInt ("PerdioPrimera",1);
				GUI1.SetActive (false);
				GUI2.SetActive (false);
				GUI3.SetActive (false);
				GUI4.SetActive (false);
				GUI5.SetActive (false);
				GetComponent<AudioSource>().Stop();

				Perdiste.SetActive (true);
			}

			if (!TerminoPartida) {
				if (PlayerPrefs.GetInt ("Sounds") == 0) {
					if (GameObject.Find ("TimerText").GetComponent<TextMesh> ().text == "1:10") {
						GetComponent<AudioSource> ().volume = 0.5f;
					}
					if (GameObject.Find ("TimerText").GetComponent<TextMesh> ().text == "0:55") {
						GetComponent<AudioSource> ().volume = 0.6f;
					}
					if (GameObject.Find ("TimerText").GetComponent<TextMesh> ().text == "0:45") {
						GetComponent<AudioSource> ().volume = 0.7f;
					}
					if (GameObject.Find ("TimerText").GetComponent<TextMesh> ().text == "0:35") {
						GetComponent<AudioSource> ().volume = 0.8f;
					}
					if (GameObject.Find ("TimerText").GetComponent<TextMesh> ().text == "0:20") {
						GetComponent<AudioSource> ().volume = 1;
						GameObject.Find ("TimerText").GetComponent<TextMesh> ().color = Color.red;
						ActivoTiempo = true;
					}
				} else {
					if (GameObject.Find ("TimerText").GetComponent<TextMesh> ().text == "0:20") {
						GameObject.Find ("TimerText").GetComponent<TextMesh> ().color = Color.red;
						ActivoTiempo = true;
					}
				}
			}
			if (ActivoTiempo) {
				if (!tiempo) {
					Invoke ("Achico", 0.4f);
				} else {
					Invoke ("Agrando", 0.4f);
				}
			}
		}

		if (Perdio) {
			if (Vidas > 0) {
				Vidas--;
				PlayerPrefs.SetInt ("Vidas", Vidas);
				Debug.Log ("VIDAS: " + PlayerPrefs.GetInt ("Vidas"));
				switch (Vidas) {
				case 4:
					PlayerPrefs.SetInt ("LoseVida4", 0);
					break;
				case 3:
					PlayerPrefs.SetInt ("LoseVida3", 0);
					break;
				case 2:
					PlayerPrefs.SetInt ("LoseVida2", 0);
					break;
				case 1:
					PlayerPrefs.SetInt ("LoseVida1", 0);
					break;
				case 0:
					PlayerPrefs.SetInt ("LoseVida0", 0);
					break;
				}
 			}
			Perdio = false;
		}
	}



		void Agrando(){
		Reloj.transform.localScale = new Vector3(0.09934664f, 0.274987f, 0.09459486f);
			tiempo = false;
		}
		void Achico(){
		Reloj.transform.localScale = new Vector3(0.1072944f, 0.296986f, 0.1021625f);
			tiempo = true;
		}
}