using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRelic : MonoBehaviour {

	public GameObject relicHUD;
	private AudioSource audio;
	public AudioClip pickupChime;

	void Start(){
		audio = GetComponent<AudioSource>();
	}

	void OnTriggerEnter(){
		audio.PlayOneShot(pickupChime, 0.3f);
		relicHUD.SetActive(true);	
		Invoke("Disable", 0.3f);	
		}
	void Disable(){
		gameObject.SetActive(false);
	}
}
