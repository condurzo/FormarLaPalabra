using UnityEngine;
using System.Collections;

public class Modo1Monedas : MonoBehaviour {
	public int Monedas;
	public TextMesh MonedasText;
	

	void Update () {
		Monedas = PlayerPrefs.GetInt("Monedas");
		MonedasText.text = Monedas.ToString();
	}
}
