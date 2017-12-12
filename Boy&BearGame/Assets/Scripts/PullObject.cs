using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PullObject : MonoBehaviour {
	public static UnityAction animDropCarry;
	void Start(){
		MoveObject.Pull += PullHandler;
		}
	void PullHandler(){
		animDropCarry();
		gameObject.transform.parent = null;
	}
}
