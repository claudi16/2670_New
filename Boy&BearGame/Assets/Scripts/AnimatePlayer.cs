using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatePlayer : MonoBehaviour {
	public Animator anims;

	void Start() {
		CharacterInput.JumpAnim+= AnimJump;
		CharacterInput.KeyAction += AnimRun;
		CharacterInput.Dash += AnimDash;
		WaterAction.SwimAnim += AnimSwim;
		CharacterMove.doubleAnim += AnimDouble;
		MoveObject.carryAnim += AnimCarry;
		PullObject.animDropCarry += AnimCarryEnd;
		HealthHarm.KBAnim += AnimInjure;
	}

	 void AnimJump(){
		if(SVars.inWater == false && Input.GetKeyDown(KeyCode.Space)){
			anims.SetTrigger("PJump");
		}
	}
	private void AnimRun(float obj){
		if(obj < 0){
			obj*= -1;
		}
		anims.SetFloat("PRun", obj);
		if(obj < 0 && Input.GetKeyDown(KeyCode.Space)){
			anims.SetTrigger("PJump");
		}
		if(obj < 0 && Input.GetKeyDown(KeyCode.Space) && SVars.jumpScore >=1){
			anims.SetTrigger("Double");
		}
	}
	private void AnimSwim(){
		if(SVars.inWater == false){
		anims.SetTrigger("PJump");
		}else{
		anims.SetTrigger("PSwim");	
		}
	}
	private void AnimDouble(){
		if(SVars.jumpScore>=1){
		anims.SetTrigger("Double");			
		}
	}
	private void AnimDash(){
		anims.SetTrigger("Dash");
	}

	private void AnimCarry(){
		anims.SetBool("Carry", true);
	}
	private void AnimCarryEnd(){
		anims.SetBool("Carry", false);
	}
	private void AnimInjure(){
		anims.SetTrigger("Injure");
	}
}
