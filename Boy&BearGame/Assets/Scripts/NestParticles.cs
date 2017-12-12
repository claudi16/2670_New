using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NestParticles : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.SetActive(false);
		NestJumpTrigger.nestFX += nestFXHandler;
	}
	void nestFXHandler(){
		gameObject.SetActive(true);
		Invoke("Disable", 2);
	}
	void Disable(){
		gameObject.SetActive(false);
	}

}
