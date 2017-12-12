using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrigger : MonoBehaviour {

	public GameObject newArea;
	private AudioSource audio;
	public AudioClip areaChime;

	void Start(){
		audio = GetComponent<AudioSource>();
		newArea.SetActive(false);
	}
	public void OnTriggerEnter(){
		audio.PlayOneShot(areaChime, 0.4f);
		newArea.SetActive(true);
	}
	public void OnTriggerExit(){
		newArea.SetActive(false);
	}
}
