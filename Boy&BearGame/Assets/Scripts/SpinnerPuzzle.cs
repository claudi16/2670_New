using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpinnerPuzzle : MonoBehaviour {
	private AudioSource audio;
	public AudioClip switchSFX;
	public static UnityAction spinAction;
	public GameObject spinActionObj;
	public GameObject spinner;
	public Animator anims;
	bool spinnerCountTF;
	bool rotTF;
		void Start(){
			spinActionObj.SetActive(false);
			audio = GetComponent<AudioSource>();
		}
		void OnTriggerStay(){
		 if (Input.GetKeyDown(KeyCode.C) && spinnerCountTF == true){
			 audio.PlayOneShot(switchSFX, 0.5f);
			 spinner.transform.rotation *= Quaternion.Euler(0,0,120);
			 rotTF = true;
			 spinnerCountTF = false;
			 Invoke("LeverAnim", 0.01f);		 
		 }
		 if(Input.GetKeyUp(KeyCode.C)){
			 spinnerCountTF = true;
			 rotTF = false;
			 Invoke("LeverAnim", 0.01f);	
		 }
		if(spinner.transform.rotation.y == 1.0 && rotTF == true || spinner.transform.rotation.y == -1.0 && rotTF == true){
		spinActionObj.SetActive(true);
		spinAction();
		rotTF = false;
		}
		if(spinner.transform.rotation.y != 1.0 && rotTF == true || spinner.transform.rotation.y != -1.0 && rotTF == true){
		spinActionObj.SetActive(false);
		spinAction();
		rotTF = false;
		}		
	}
		void LeverAnim(){      			//Animation
			anims.SetBool("isSwitch", true);
			Invoke("LeverAnimStop", 0.01f);
		}
		void LeverAnimStop(){			//AnimationStop
			anims.SetBool("isSwitch",false);
		}
}
