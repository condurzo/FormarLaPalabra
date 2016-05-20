using UnityEngine;
using System.Collections;

public class Modo2Nivel : MonoBehaviour {
	public int Level;
	public TextMesh NivelText;

	void Awake () {
		Level = PlayerPrefs.GetInt("level2");
		NivelText.text = Level.ToString();
	}
}
