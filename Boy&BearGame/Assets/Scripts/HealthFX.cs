using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthFX : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.SetActive(false);
		CharacterHealth.healthFX += healthFXHandler;
	}
	void healthFXHandler(){
		gameObject.SetActive(true);
		Invoke("HideFX", 0.5f);
	}
	void HideFX(){
		gameObject.SetActive(false);
	}

}
