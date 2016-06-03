using UnityEngine;
using System.Collections;

public class Modo4Nivel : MonoBehaviour {
	public int Level;
	public TextMesh NivelText;

	void Awake () {
		Level = PlayerPrefs.GetInt("level4");
		NivelText.text = Level.ToString();
	}
}
