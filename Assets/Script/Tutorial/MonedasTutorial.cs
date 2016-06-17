using UnityEngine;
using System.Collections;

public class MonedasTutorial : MonoBehaviour {

	public int Monedas;
	public TextMesh MonedasText;

	void Update () {
		Monedas = PlayerPrefs.GetInt("Monedas");
		MonedasText.text = Monedas.ToString();
	}
}
