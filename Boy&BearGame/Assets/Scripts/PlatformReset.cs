using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformReset : MonoBehaviour {

	bool useGravity;
	Vector3 originalPosition;
	void Start(){
		originalPosition = gameObject.transform.position;
	}
	void OnTriggerEnter(Collider touch)
	{
		if(touch.gameObject.tag == "PlatformResetFall"){
		gameObject.GetComponent<Rigidbody>().useGravity = false;	
		gameObject.GetComponent<Rigidbody>().isKinematic = true;	
		transform.position = originalPosition;
		gameObject.SetActive(false);
		Invoke("PlatformKin", 2f);
		}
	}
		void PlatformKin(){
		gameObject.SetActive(true);
		gameObject.GetComponent<Rigidbody>().isKinematic = false;
	}
}
