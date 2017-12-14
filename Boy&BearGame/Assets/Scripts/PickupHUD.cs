using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupHUD : MonoBehaviour {

	public Sprite[] PickupSprites;
	public Image PickupSpritesTracker;
	public GameObject endWall;

	void Start(){	
		BushReset.caveBerryReset += berryResetHandler;
		PickUp.Picked += PickedHandler;
		ResetAll.resetHUD += resetHUDHandler;
		PickupSpritesTracker.sprite = PickupSprites[SVars.pickupCounter];	
	}	
	void PickedHandler(){//Add to Counter
		SVars.pickupCounter++;
		PickupSpritesTracker.sprite = PickupSprites[SVars.pickupCounter];
		if(SVars.pickupCounter == 3){
			endWall.SetActive(false);
		}
	}
	void resetHUDHandler(){//Reset Items HUD
		SVars.pickupCounter = 0;
		PickupSpritesTracker.sprite = PickupSprites[0];	
		print("hi");
	}
	void berryResetHandler(){//ResetCounter
		SVars.pickupCounter--;
		PickupSpritesTracker.sprite = PickupSprites[SVars.pickupCounter];
	}
}
