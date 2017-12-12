using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class CharacterHealth : MonoBehaviour {

	public Sprite[] HeartSprites;
	public Image HeartSpritesTracker;
	public static UnityAction healthFX;
	public static UnityAction ResetGame;
	public bool AddHealth = true;
	public bool ishealthCount = true;
	private AudioSource audio;
	public AudioClip healthChime;

	void Start(){
		audio = GetComponent<AudioSource>();
		ResetAll.resetHealth += resetHealthHandler;
		HealthHarm.Hurt += HurtHandler;		
		HeartSpritesTracker.sprite = HeartSprites[SVars.healthCounter];
		PickUpCounter.ThreeBerryHealth += ThreeBerryHealthHandler;		
	}	
	void HurtHandler(){	//Take Away Health	
		SVars.healthCounter++;		
		HeartSpritesTracker.sprite = HeartSprites[SVars.healthCounter];	

			if(SVars.healthCounter >=3){//Reset Count
		SVars.inWater = false;
		SVars.healthCounter = 0;
		HeartSpritesTracker.sprite = HeartSprites[0];
		ResetGame();
		}
	}
	void ThreeBerryHealthHandler(){//Add Health Per 3 Berries
		if(SVars.healthCounter >=1){
		healthFX();
		audio.PlayOneShot(healthChime, 0.4f);//Health SFX
		SVars.healthCounter --;
		HeartSpritesTracker.sprite = HeartSprites[SVars.healthCounter];			
		}
	}
	void resetHealthHandler(){//Reset Game Health
		SVars.healthCounter = 0;
		HeartSpritesTracker.sprite = HeartSprites[0];		
	}

}	