using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class HealthHearts : MonoBehaviour {
//GET RID OF IT ALL
	/*public Sprite[] HeartSprites;
	public Image HeartSpritesTracker;
	public static UnityAction ResetGame;
	public bool AddHealth = true;
	//public bool ishealthCount;

	void Start(){
		ResetAll.resetHealth += resetHealthHandler;
		//HealthHarm.Hurt += HurtHandler;	
		//StartCoroutine(ThreeHealth());	
	}	
	
	/*IEnumerator ThreeHealth(){ //Regain Health
		while(AddHealth){
			if(SVars.berryCount % 3 == 0 && SVars.healthCounter <= 2 && SVars.healthCounter >= 1){
				print("health added");
			SVars.healthCounter += 1;
			}
		yield return new WaitForSeconds(0.1f);			
		}

	}
	IEnumerator HeartTrack(){
		while(ishealthCount){
		HeartSpritesTracker.sprite = HeartSprites[SVars.healthCounter];	
		yield return new WaitForSeconds(0.1f);
		}
	}*/

	/*void HurtHandler(){
		if(HealthHarm.harmOnce == true){
		SVars.healthCounter++;
		HealthHarm.harmOnce = false;	
		StartCoroutine(HeartTrack());		
		}
		//HeartSpritesTracker.sprite = HeartSprites[SVars.healthCounter];		
		if(SVars.healthCounter >=3){//Reset Count
		SVars.inWater = false;
		SVars.healthCounter = 0;
		HeartSpritesTracker.sprite = HeartSprites[0];
			ResetGame();
		}
	}
	void resetHealthHandler(){
		SVars.healthCounter = 0;
		HeartSpritesTracker.sprite = HeartSprites[0];		
	}*/

}
