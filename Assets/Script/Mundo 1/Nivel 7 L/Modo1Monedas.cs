using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Modo1Monedas : MonoBehaviour {
	public int Monedas;
	public TextMesh MonedasText;
	public TextMesh VidasInGame;

	void Update () {
		Monedas = PlayerPrefs.GetInt("Monedas");
		MonedasText.text = Monedas.ToString();
		VidasInGame.text = GameObject.Find("VidasText1False").GetComponent<Text>().text;
	}
}
