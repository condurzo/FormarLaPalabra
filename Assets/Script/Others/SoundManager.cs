using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	void Awake () {
		if (PlayerPrefs.GetInt ("Sounds") == 0) {
			AudioListener.volume = 1;
		}else{
			AudioListener.volume = 0;
		}
	}

	void Start(){
		if (PlayerPrefs.GetInt ("Sounds") == 0) {
			AudioListener.volume = 1;
		}else{
			AudioListener.volume = 0;
		}
	}

	void Update(){
		if(Application.loadedLevelName=="SelectorMundos"){
			if (PlayerPrefs.GetInt ("Sounds") == 0) {
				AudioListener.volume = 1;
			}else{
				AudioListener.volume = 0;
			}
		}
	}

}
