using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CaveLightEnter : MonoBehaviour {
	public static UnityAction fadeInAnim;
	public static UnityAction fadeOutAnim;
	void OnTriggerEnter(){
		fadeInAnim();
	}
	void OnTriggerExit(){
		fadeOutAnim();
	}
}
