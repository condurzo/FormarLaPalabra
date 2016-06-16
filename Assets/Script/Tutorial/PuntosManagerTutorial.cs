using UnityEngine;
using System.Collections;

public class PuntosManagerTutorial : MonoBehaviour {

	public float Seg;
	public float Min;
	public int Puntos;
	public float MinTemp;
	public int PuntosTemp;
	public TextMesh PuntosText;

	void Start () {
		Puntos = PlayerPrefs.GetInt ("PuntosTotal");
	}

	void Update () {
		if (CountdownTimer_CSHARP.TerminoPartida) {
				Seg = CountdownTimer_CSHARP.SegundosPuntos*2;
				Min = CountdownTimer_CSHARP.MinutosPuntos;
				if (Min >= 1) {
					MinTemp = 200;
				}
				PuntosTemp = (int)Seg + (int)MinTemp;
				int PuntosTotal = PuntosTemp + Puntos;
				PlayerPrefs.SetInt ("PuntosTotal", PuntosTotal);
				PuntosText.text = PuntosTemp.ToString ();
		}
	}
}
