using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ResetAll : MonoBehaviour {
	public static UnityAction resetHealth;
	public static UnityAction resetHUD;
	public static UnityAction resetBerries;
	//public static UnityAction resetPos;
	Vector3 originalPosition;
	Quaternion originalRot;
	void Start(){
		originalPosition = gameObject.transform.position;
		originalRot = gameObject.transform.rotation;
		GameOver.resetAll += resetAllHandler;
	}
	public void resetAllHandler(){
		gameObject.SetActive(true);			
		gameObject.transform.position = originalPosition;
		SVars.inWater = false;	
		Time.timeScale = 1;		
		SVars.jump = true;
		gameObject.transform.rotation = originalRot;	
		//resetPos();	
		resetBerries();
		resetHealth();
		resetHUD();
		Invoke("CloseMenu", 0.2f);
	}
	void CloseMenu(){
	GameObject.FindWithTag("PauseMenu").SetActive(false);	
	}
}
