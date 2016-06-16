using UnityEngine;
using System.Collections;

public class GarbageCol : MonoBehaviour {

	void Awake(){
		
	}

	// Use this for initialization
	void Start () {
		System.GC.Collect();  
		Debug.Log ("PaseGarbage");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
