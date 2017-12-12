using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateFishBig : MonoBehaviour {
	public Animator anim;
	//public static bool isSwimming = false;

	void Start () {
		anim = GetComponent<Animator>();
		//anim.SetBool("isSwimming", true);
		
	}
}
