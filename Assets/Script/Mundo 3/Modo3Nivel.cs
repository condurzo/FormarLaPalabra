using UnityEngine;
using System.Collections;

public class Modo3Nivel : MonoBehaviour {
	public int Level;
	public TextMesh NivelText;

	void Awake () {
		Level = PlayerPrefs.GetInt("level3");
		NivelText.text = Level.ToString();
	}
}
