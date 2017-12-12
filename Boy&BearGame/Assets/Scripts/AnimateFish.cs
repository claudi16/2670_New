using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateFish : MonoBehaviour {
	public Animator anim;
	//public static bool isSwimming = false;

	void Start () {
		anim = GetComponent<Animator>();
		EnemyFollow.Swim += SwimHandler;
		EnemyFollow.Idle += IdleHandler;
	}
	void SwimHandler(){
		anim.SetBool("isSwimming", true);
	}
	void IdleHandler(){
		anim.SetBool("isSwimming", false);
	}
}
