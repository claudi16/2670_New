using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPuzzle3 : MonoBehaviour {

	public GameObject boxCol;
	private static int boxTriggered = 0;
	public GameObject newArea;
	private AudioSource audio;
	public AudioClip switchSFX;

	void Start(){
		//CHANGE TO FALSE
		newArea.SetActive(false);
		audio = GetComponent<AudioSource>();
	}
	public void OnTriggerEnter(Collider box){
		if(box.gameObject == boxCol){
		boxTriggered++;			
		}
		if(boxTriggered == 2){
		audio.PlayOneShot(switchSFX, 0.3f);
		newArea.SetActive(true);
		}
	}
	public void OnTriggerExit(Collider box){
		if(box.gameObject == boxCol){
			boxTriggered--;
		}
	}
}
