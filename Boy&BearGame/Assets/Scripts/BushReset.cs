using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BushReset : MonoBehaviour {
	
	public static UnityAction caveBerryReset;

	void OnTriggerEnter(Collider other){
	if(other.gameObject.tag == "Indy"){
	gameObject.SetActive(false);
		}
	if(SVars.pickupCounter >= 1){
		caveBerryReset();
		}
	}
}
