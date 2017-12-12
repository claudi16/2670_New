using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveLightDim: MonoBehaviour {
	public Animator anims;

	void Start(){
		anims.SetBool("FadeHide", true);
		CaveLightEnter.fadeInAnim += AnimFadeIn;
		CaveLightEnter.fadeOutAnim += AnimFadeOut;
	}
	void AnimFadeIn(){
		anims.SetBool("isFade", true);
	}
	void AnimFadeOut(){
		anims.SetBool("isFade", false);
	}
}
