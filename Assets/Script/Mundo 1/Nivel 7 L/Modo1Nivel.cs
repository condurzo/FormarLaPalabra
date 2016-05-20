using UnityEngine;
using System.Collections;

public class Modo1Nivel : MonoBehaviour {
	public int Level;
	public TextMesh NivelText;
		
	void Awake () {
		Level = PlayerPrefs.GetInt("level");
		NivelText.text = Level.ToString();
	}
	

}
