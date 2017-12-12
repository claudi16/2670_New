using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
	public GameObject door;
	public GameObject relicItem;
	public GameObject relicHUD;
	private AudioSource audio;
	public AudioClip pickupChime;

	void Start(){
		relicItem.SetActive(false);
		audio = GetComponent<AudioSource>();//Audio
	}
	void OnTriggerEnter(){
		if(relicHUD.activeInHierarchy == true){
		audio.PlayOneShot(pickupChime, 0.5f);//Audio
		relicItem.SetActive(true);
		door.SetActive(false);	
		transform.gameObject.GetComponent<Collider>().enabled = false;
		relicHUD.SetActive(false);	
		}
	}

}
