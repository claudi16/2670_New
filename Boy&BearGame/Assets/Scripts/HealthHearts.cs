using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class HealthHearts : MonoBehaviour {

	public Sprite[] HeartSprites;
	public Image HeartSpritesTracker;
	public static Action ResetGame;
	public bool AddHealth = true;

	void Start(){
		ResetAll.resetHealth += resetHealthHandler;
		HealthHarm.Hurt += HurtHandler;	
		StartCoroutine(ThreeHealth());	
	}	
	
	IEnumerator ThreeHealth(){ //Regain Health
		while(AddHealth){
			if(SVars.berryCount % 3 == 0 && SVars.healthCounter <= 2 && SVars.healthCounter >= 1){
				print("health added");
			SVars.healthCounter += 1;
			SVars.berryCount++;
			}
		yield return new WaitForSeconds(0.1f);			
		}

	}

	void HurtHandler(){
		if(HealthHarm.harmOnce == true){
		SVars.healthCounter++;
		HealthHarm.harmOnce = false;			
		}
		HeartSpritesTracker.sprite = HeartSprites[SVars.healthCounter];		
		if(SVars.healthCounter >=3){
		SVars.inWater = false;
		SVars.healthCounter = 0;
		HeartSpritesTracker.sprite = HeartSprites[0];
			ResetGame();
		}
	}
	void resetHealthHandler(){
		SVars.healthCounter = 0;
		HeartSpritesTracker.sprite = HeartSprites[0];		
	}

}
