using UnityEngine;
using System.Collections;

public class TutorialNivel : MonoBehaviour {

	public int Level;
	public TextMesh NivelText;

	void Awake () {
		Level = PlayerPrefs.GetInt("levelTutorial");
		NivelText.text = Level.ToString();
	}

}
