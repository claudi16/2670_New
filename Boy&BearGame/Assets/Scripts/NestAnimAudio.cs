using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NestAnimAudio : MonoBehaviour {
	private AudioSource audio;
	public AudioClip crackAudio;
	public AudioClip crack2Audio;
	public AudioClip breakAudio;
	void Start () {
		audio = GetComponent<AudioSource>();
		NestJumpTrigger.crackSFX += crackSFXHandler;
		NestJumpTrigger.nestFall += nestFallFX;
	}
	void crackSFXHandler(){
		audio.PlayOneShot(crackAudio, 0.4f);
	}
	void nestFallFX(){
		transform.GetChild(0).gameObject.SetActive(false);//Destroy Nest Collider
		audio.PlayOneShot(crack2Audio, 0.5f);
		audio.PlayOneShot(breakAudio, 0.4f);
	}
	
}
