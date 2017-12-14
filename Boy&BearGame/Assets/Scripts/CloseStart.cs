using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CloseStart : MonoBehaviour {
	public static UnityAction showHUD;
	private AudioSource audio;//Audio
	public AudioClip chimeSFX;	

	void Start(){
		audio = GetComponent<AudioSource>();
	}
	public void CloseSplash(){
	audio.PlayOneShot(chimeSFX, 0.4f);
	showHUD();
	GameObject.Find("StartScreen").SetActive(false);
	}
}
