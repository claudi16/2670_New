using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NestJumpTrigger : MonoBehaviour {
	public static UnityAction nestFall;
	public static UnityAction crackSFX;
	public static UnityAction nestFX;
	public bool isTriggered = true;
	private int jumpCount;

	void OnTriggerEnter(){
		isTriggered = true;
		StartCoroutine(JumpBridge());
	}
	IEnumerator JumpBridge(){
		while(isTriggered){
			if(Input.GetKeyDown(KeyCode.Space)){
				jumpCount++;
				crackSFX();
			}
			if(jumpCount >= 3){
				Invoke("BreakNest", 0.01f);
			}
		yield return new WaitForSeconds(0.01f);
		}
	}
	void OnTriggerExit(){
		isTriggered = false;
	}
	void BreakNest(){
		nestFX();
		nestFall();
		gameObject.SetActive(false);
	}

}
