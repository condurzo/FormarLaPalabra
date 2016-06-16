using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ManagerSelectorMundos : MonoBehaviour {

	public Button[] BotonesBloqueados;
	public Image[] MundosTerminados;
	public Text[] MundosTextos;
	public int SelectorMundosCont;
	public admobscript ads;
	public static int numPantalla;
	public Sprite MundoGanado;

	public GameObject Pelotita1;
	public GameObject Pelotita2;
	public GameObject Pelotita3;
	public GameObject Pelotita4;

	public GameObject FlechaDer;
	public GameObject FlechaIzq;
	public bool tiempo;
	public bool mostrando;

	public int VidasTemp;

	void Start () {
		ads.ShowBanner ();

		//BOTONES BLOQUEADOS
		if (PlayerPrefs.GetInt ("Desblo-Nivel1-Ver1") == 0) {
			BotonesBloqueados [0].interactable = false;
		}
		if (PlayerPrefs.GetInt ("Desblo-Nivel2-Ver1") == 0) {
			BotonesBloqueados [1].interactable = false;
		}
		if (PlayerPrefs.GetInt ("Desblo-Nivel3-Ver1") == 0) {
			BotonesBloqueados [2].interactable = false;
		}
		if (PlayerPrefs.GetInt ("Desblo-Nivel4-Ver1") == 0) {
			BotonesBloqueados [3].interactable = false;
		}

		//MUNDOS GANADOS, CAMBIO DE IMAGEN
		if (PlayerPrefs.GetInt ("Stop-Nivel1-Ver1") == 1) {
			MundosTerminados [0].sprite = MundoGanado;
		}
		if (PlayerPrefs.GetInt ("Stop-Nivel2-Ver1") == 1) {
			MundosTerminados [1].sprite = MundoGanado;
		}
		if (PlayerPrefs.GetInt ("Stop-Nivel3-Ver1") == 1) {
			MundosTerminados [2].sprite = MundoGanado;
		}
		if (PlayerPrefs.GetInt ("Stop-Nivel4-Ver1") == 1) {
			MundosTerminados [3].sprite = MundoGanado;
		}

		//Numero de Niveles en Cada Mundo.
		MundosTextos [0].text = PlayerPrefs.GetInt ("level").ToString ();
		MundosTextos [1].text = PlayerPrefs.GetInt ("level2").ToString ();
		MundosTextos [2].text = PlayerPrefs.GetInt ("level3").ToString ();
		MundosTextos [3].text = PlayerPrefs.GetInt ("level4").ToString ();

	}

	public void noMostrar(){
		mostrando = true;
	}
	public void Mostrar(){
		mostrando = false;
	}

	void Agrando(){
		FlechaDer.transform.localScale = new Vector3(1f, 1f, 1f);
		FlechaIzq.transform.localScale = new Vector3(1f, 1f, 1f);
		tiempo = false;
	}
	void Achico(){
		FlechaDer.transform.localScale = new Vector3(0.85f, 0.85f, 0.85f);
		FlechaIzq.transform.localScale = new Vector3(0.85f, 0.85f, 0.85f);
		tiempo = true;
	}

	void Update(){
		VidasTemp = PlayerPrefs.GetInt ("Vidas");

		if (!tiempo) {
			Invoke ("Achico", 0.4f);
		} else {
			Invoke ("Agrando", 0.4f);
		}

		switch (numPantalla) {
		case 0:
			Pelotita1.GetComponent<Image> ().color = Color.white;
			Pelotita2.GetComponent<Image> ().color = Color.grey;
			Pelotita3.GetComponent<Image> ().color = Color.grey;
			Pelotita4.GetComponent<Image> ().color = Color.grey;
			if (!mostrando) {
				FlechaDer.SetActive (true);
				FlechaIzq.SetActive (false);
			} else {
				FlechaDer.SetActive (false);
				FlechaIzq.SetActive (false);
			}
			break;
		case 1:
			Pelotita1.GetComponent<Image> ().color = Color.grey;
			Pelotita2.GetComponent<Image> ().color = Color.white;
			Pelotita3.GetComponent<Image> ().color = Color.grey;
			Pelotita4.GetComponent<Image> ().color = Color.grey;
			if (!mostrando) {
				FlechaDer.SetActive (true);
				FlechaIzq.SetActive (true);
			} else {
				FlechaDer.SetActive (false);
				FlechaIzq.SetActive (false);
			}
			break;
		case 2:
			Pelotita1.GetComponent<Image> ().color = Color.grey;
			Pelotita2.GetComponent<Image> ().color = Color.grey;
			Pelotita3.GetComponent<Image> ().color = Color.white;
			Pelotita4.GetComponent<Image> ().color = Color.grey;
			if (!mostrando) {
				FlechaDer.SetActive (true);
				FlechaIzq.SetActive (true);
			} else {
				FlechaDer.SetActive (false);
				FlechaIzq.SetActive (false);
			}
			break;
		case 3:
			Pelotita1.GetComponent<Image> ().color = Color.grey;
			Pelotita2.GetComponent<Image> ().color = Color.grey;
			Pelotita3.GetComponent<Image> ().color = Color.grey;
			Pelotita4.GetComponent<Image> ().color = Color.white;
			if (!mostrando) {
				FlechaDer.SetActive (false);
				FlechaIzq.SetActive (true);
			} else {
				FlechaDer.SetActive (false);
				FlechaIzq.SetActive (false);
			}
			break;
		}
	}


	public void GoToMundo1(){
		if (VidasTemp >= 1) {
			if (PlayerPrefs.GetInt ("Stop-Nivel1-Ver1") == 0) {
				if (PlayerPrefs.GetInt ("Desblo-Nivel1-Ver1") == 1) {
					if (PlayerPrefs.GetInt ("UnicaVez1") == 0) {
						PlayerPrefs.SetInt ("level", 1);
						PlayerPrefs.SetInt ("UnicaVez1", 1);
					}
					SceneManager.LoadScene ("Nivel1");
				}
			}
		}
	}
	public void GoToMundo2(){
		if (VidasTemp >= 1) {
			if (PlayerPrefs.GetInt ("Stop-Nivel2-Ver1") == 0) {
				if (PlayerPrefs.GetInt ("Desblo-Nivel2-Ver1") == 1) {
					if (PlayerPrefs.GetInt ("UnicaVez2") == 0) {
						PlayerPrefs.SetInt ("level2", 1);
						PlayerPrefs.SetInt ("UnicaVez2", 1);
					}
					SceneManager.LoadScene ("Nivel2");
				}
			}
		}
	}
	public void GoToMundo3(){
		if (VidasTemp >= 1) {
			if (PlayerPrefs.GetInt ("Stop-Nivel3-Ver1") == 0) {
				if (PlayerPrefs.GetInt ("Desblo-Nivel3-Ver1") == 1) {
					if (PlayerPrefs.GetInt ("UnicaVez3") == 0) {
						PlayerPrefs.SetInt ("level3", 1);
						PlayerPrefs.SetInt ("UnicaVez3", 1);
					}
					SceneManager.LoadScene ("Nivel3");
				}
			}
		}
	}
	public void GoToMundo4(){
		if (VidasTemp >= 1) {
			if (PlayerPrefs.GetInt ("Stop-Nivel4-Ver1") == 0) {
				if (PlayerPrefs.GetInt ("Desblo-Nivel4-Ver1") == 1) {
					if (PlayerPrefs.GetInt ("UnicaVez4") == 0) {
						PlayerPrefs.SetInt ("level4", 1);
						PlayerPrefs.SetInt ("UnicaVez4", 1);
					}
					SceneManager.LoadScene ("Nivel4");
				}
			}
		}
	}

}
