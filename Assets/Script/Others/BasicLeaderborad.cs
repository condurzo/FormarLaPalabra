using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BasicLeaderborad : MonoBehaviour {

	public Text Puntos;

	void Start () {
		Puntos.text = PlayerPrefs.GetInt ("PuntosTotal").ToString ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
