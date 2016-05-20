using UnityEngine;
using System.Collections;

public class Examples : MonoBehaviour {

	public admobscript admob;

	// Use this for initialization
	void Start () {
		admob.ShowInterstitial();
		//admob.HideBanner();
		admob.ShowBanner();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
