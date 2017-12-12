using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBridge : MonoBehaviour {
	public GameObject brokenBridge;
	public GameObject bridge;

	void Start(){
		NestJumpTrigger.nestFall += nestFallHandler;
		brokenBridge.SetActive(false);
	}
	void OnTriggerEnter(){
		bridge.SetActive(false);
		brokenBridge.SetActive(true);
		gameObject.SetActive(false);		
	}
	void nestFallHandler(){
		gameObject.GetComponent<Rigidbody>().useGravity = true;
	}
}