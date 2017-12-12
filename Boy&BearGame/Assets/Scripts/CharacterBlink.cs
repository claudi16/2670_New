using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBlink : MonoBehaviour {
	public Renderer render;
	bool blinkCount = false;

	void Start(){
		render.enabled = true;
		HealthHarm.Blink += BlinkHandler;
	}
	void BlinkHandler(){
		blinkCount = true;
		StartCoroutine(Blinking());
		Invoke("BlinkEnd", 2);
		gameObject.layer = 17;
	}

	IEnumerator Blinking(){
		while(blinkCount == true){
			render.enabled = !render.enabled;			
			SVars.blinks++;
			yield return new WaitForSeconds(0.04f);
		}
		render.enabled = true;
	}
	void BlinkEnd(){//End Blinking
		blinkCount = false;
		gameObject.layer = 8;
	}
}
