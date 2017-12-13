using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bear : MonoBehaviour {

	void OnTriggerEnter()	{ 
		if(SVars.pickupCounter == 3){
			transform.gameObject.GetComponent<Collider>().enabled = false;
		}
	}
}
