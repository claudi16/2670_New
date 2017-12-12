using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HealthHarm : MonoBehaviour {
	public static Action Hurt;
	public static Action KnockBack;
	public static Action Blink;
	public static Action KBAnim;
	GameObject objHarm;
	public static bool harmOnce;
	public static bool blinkCount = false;

	void OnControllerColliderHit(ControllerColliderHit hit){
		if(hit.gameObject.tag == "Indy"){
		Hurt();
		}
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "ResetFall" || other.gameObject.tag == "Enemy"){
		blinkCount = true;
		gameObject.layer = 17;			
		harmOnce = true;
		SVars.blinks = 0;
		KBAnim();
		Hurt();
		KnockBack();
		Blink();
		Invoke("BlinkEnd", 2);
		}
	}
	void OnTriggerExit(){
		harmOnce = false;
	}
	void BlinkEnd(){
		blinkCount = false;
		gameObject.layer = 8;
	}
}
