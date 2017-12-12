using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTriggerColor : MonoBehaviour {

	public GameObject trigger;
	public GameObject boxCol;
	private static int boxTriggered = 0;
	public GameObject newArea;
	private AudioSource audio;
	public AudioClip chimeSFX;

	void Start(){
		audio = GetComponent<AudioSource>();
		newArea.SetActive(false);
	}
	public void OnTriggerEnter(Collider box){
		if(box.gameObject == boxCol){
		boxTriggered++;			
		}
		if(boxTriggered == 2){
		audio.PlayOneShot(chimeSFX, 0.4f);
		newArea.SetActive(true);
		}
	}
	public void OnTriggerExit(Collider box){
		if(box.gameObject == boxCol){
			boxTriggered--;
		}
	}
}
