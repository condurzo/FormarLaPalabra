using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ManagerSelectorMundos : MonoBehaviour {

	public Image[] MundosBloqueados;
	public Image[] MundosLibres;
	public int SelectorMundosCont;
	public admobscript ads;

	void Start () {
		ads.ShowBanner ();

		SelectorMundosCont = PlayerPrefs.GetInt ("SelectorMundos");
		switch (SelectorMundosCont) {
		case 0:
			break;
		case 1://
			break;
		case 2: 
			break;
		case 3:
			break;
		case 4:
			break;
		case 5:
			break;
		case 6:
			break;

		}
	}
	public void GoToMundo1(){
		if (PlayerPrefs.GetInt ("UnicaVez1") == 0) {
			PlayerPrefs.SetInt ("level", 1);
			PlayerPrefs.SetInt ("UnicaVez1", 1);
		}
		SceneManager.LoadScene ("Nivel1");
	}
	public void GoToMundo2(){
		if (PlayerPrefs.GetInt ("UnicaVez2") == 0) {
			PlayerPrefs.SetInt ("level2", 1);
			PlayerPrefs.SetInt ("UnicaVez2", 1);
		}
		SceneManager.LoadScene ("Nivel2");
	}

}
