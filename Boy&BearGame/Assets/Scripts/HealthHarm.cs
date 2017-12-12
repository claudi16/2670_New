using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthHarm : MonoBehaviour {
	public static UnityAction Hurt;
	public static UnityAction KnockBack;
	public static UnityAction Blink;
	public static UnityAction KBAnim;
	public static UnityAction CheckpointChar;
	GameObject objHarm;
	private AudioSource audio;
	public AudioClip injureAudio;
	public static bool harmOnce = false;

	void Start(){
		audio = GetComponent<AudioSource>();
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Enemy" || other.gameObject.tag == "Indy"){	
		audio.PlayOneShot(injureAudio, 0.4f);	//Audio SFX	
		Hurt();	
		KBAnim();
		KnockBack();
		Blink();
		}
		if(other.gameObject.tag == "ResetFall"){
		audio.PlayOneShot(injureAudio, 0.4f); //Audio SFX
		Hurt();
		CheckpointChar();
		}
	}
}
