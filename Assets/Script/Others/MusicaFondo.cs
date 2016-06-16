using UnityEngine;
using System.Collections;

public class MusicaFondo : MonoBehaviour {

	void Awake() {
		DontDestroyOnLoad(this);

		if (FindObjectsOfType(GetType()).Length > 1)
		{
			Destroy(gameObject);
		}
	}
}
