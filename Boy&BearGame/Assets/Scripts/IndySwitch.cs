using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndySwitch : MonoBehaviour {
	public GameObject door;
	private AudioSource audio;
	public AudioClip switchSFX;
	public AudioClip rumbleSFX;
	public Animator anims;

	void Start () {
		audio = GetComponent<AudioSource>();
	}
	void OnTriggerStay(){
		if (Input.GetKeyDown(KeyCode.C)){
			 audio.PlayOneShot(switchSFX, 0.5f);
			 audio.PlayOneShot(rumbleSFX, 0.4f);
			 Invoke("LeverAnim", 0.01f);	
			 door.SetActive(false);	 
		}
	}
	void LeverAnim(){//Animation
			anims.SetBool("isSwitch", true);
			Invoke("LeverAnimStop", 0.04f);
	}
	void LeverAnimStop(){//AnimationStop
			anims.SetBool("isSwitch",false);
	}
}
