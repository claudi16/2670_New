using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRockUnparent : MonoBehaviour {
	GameObject pick;
	void Start(){
		pick = GameObject.Find("Pickup");
	}
	void OnTriggerEnter(){
		pick.transform.DetachChildren();
	}
}
