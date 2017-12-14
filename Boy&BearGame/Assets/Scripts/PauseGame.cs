using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PauseGame : MonoBehaviour {
	private AudioSource audio;
	public AudioClip chimeSFX;

	public static UnityAction pauseMenu;

	void Start(){//Audio
		audio = GetComponent<AudioSource>();
	}
	public void Pause(){
		audio.PlayOneShot(chimeSFX, 0.4f);
		SVars.jump = false;
		pauseMenu();
	 	Time.timeScale = 0;
	}
}
