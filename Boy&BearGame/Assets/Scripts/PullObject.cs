using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PullObject : MonoBehaviour {
	public static Action animDropCarry;
	void Start(){
		MoveObject.Pull += PullHandler;
		}
	void PullHandler(){
		animDropCarry();
		gameObject.transform.parent = null;
	}
}
