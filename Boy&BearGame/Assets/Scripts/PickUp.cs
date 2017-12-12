using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PickUp : MonoBehaviour {
	public static UnityAction BearItem;
	public static UnityAction Picked;
	public GameObject newArea;
	private AudioSource audio;
	public AudioClip pickupChime;

	void Start(){//SET TO FALSE
		audio = GetComponent<AudioSource>();
		ResetAll.resetHUD += resetHUDHandler;
		BushReset.caveBerryReset += berryResetHandler;
		newArea.SetActive(false);
	}
	void OnTriggerEnter(){
		audio.PlayOneShot(pickupChime, 0.6f);
		Picked();
		Invoke("Disable", 0.25f);
		newArea.gameObject.SetActive(true);
	}		
	void Disable(){
			gameObject.SetActive(false);	
	}
	void resetHUDHandler(){
		gameObject.SetActive(true);
		newArea.SetActive(false);
	}
	void berryResetHandler(){
		gameObject.SetActive(true);
	}
}
