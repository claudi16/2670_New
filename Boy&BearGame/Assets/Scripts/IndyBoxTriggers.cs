using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndyBoxTriggers : MonoBehaviour {
	public GameObject boxCol;
	private static int boxTriggered = 0;
	public GameObject indyLever;
	private AudioSource audio;
	public AudioClip switchSFX;

	void Start(){
		//CHANGE TO FALSE
		indyLever.SetActive(false);
		audio = GetComponent<AudioSource>();
	}
	public void OnTriggerEnter(Collider box){
		if(box.gameObject == boxCol){
		boxTriggered++;			
		}
		if(boxTriggered == 2){
		audio.PlayOneShot(switchSFX, 0.5f);
		indyLever.SetActive(true);
		}
	}
	public void OnTriggerExit(Collider box){
		if(box.gameObject == boxCol){
			boxTriggered--;
		}
	}
}
