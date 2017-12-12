using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class PickUpCounter : MonoBehaviour {
	public static UnityAction berryCountAct;
	public static UnityAction ThreeBerryHealth;
	private AudioSource audio;
	public AudioClip pickupChime;

	void Start(){
		audio = GetComponent<AudioSource>();
	}
	void OnTriggerEnter(){
		SVars.berryCount++;
		audio.PlayOneShot(pickupChime, 0.3f);
		if(SVars.berryCount % 3 == 0){
			ThreeBerryHealth();
		}
		berryCountAct();
		Invoke("Disable", 0.25f);//To let sfx play through
	}
	void Disable(){
		gameObject.SetActive(false);	
	}
}
