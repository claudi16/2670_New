using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ResetAll : MonoBehaviour {
	public static UnityAction resetHealth;
	public static UnityAction resetHUD;
	Vector3 originalPosition;
	Quaternion originalRot;
	void Start(){
		originalPosition = gameObject.transform.position;
		originalRot = gameObject.transform.rotation;
		GameOver.resetAll += resetAllHandler;
	}
	public void resetAllHandler(){
		gameObject.transform.position = originalPosition;
		gameObject.SetActive(true);	
		SVars.inWater = false;	
		Time.timeScale = 1;		
		SVars.jump = true;
		SVars.healthCounter = 0;
		resetHealth();
		resetHUD();
		Invoke("CloseMenu", 0.1f);
		gameObject.transform.rotation = originalRot;
	}
	void CloseMenu(){
	GameObject.FindWithTag("PauseMenu").SetActive(false);	
	}
}
