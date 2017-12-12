using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharacterMove : MonoBehaviour {
	public static Action doubleAnim;
	CharacterController cc;
	Vector3 tempMove;
	float knockback = 2f;
	float knockCounter;
	void Start () 
	{
		cc = GetComponent<CharacterController>();
				CharacterInput.KeyAction += Move;
				CharacterInput.JumpAction = Jump;
				EnemyKill.Bounce += BounceHandler;
	}

	void Move (float _movement) 
		{
		cc.Move(tempMove);	
		tempMove.y -= SVars.gravity*Time.deltaTime;
		tempMove.x = _movement*SVars.speed*Time.deltaTime;
		if (cc.isGrounded && SVars.inWater == false){

			tempMove.y = 0;
			SVars.jumpScore = 0;
		}
		if(SVars.inWater == true){
			SVars.jumpScore = 3;		
		}
		if(SVars.inWater == true && cc.isGrounded){
			tempMove.y = 0;
		}

	}
	void Jump(){
		if(SVars.jumpScore < 2){
			doubleAnim();
			tempMove.y = SVars.jumpHeight;
			SVars.jumpScore++;
		}
		if(SVars.jumpScore >=3){
			tempMove.y = SVars.jumpHeight;
		}
	}
	void OnTriggerEnter(Collider other){ //KNOCKBACK
		if(other.gameObject.tag == "ResetFall" || other.gameObject.tag == "Enemy"){	
			if(other.transform.position.x <= gameObject.transform.position.x){
			 tempMove.y = 0.1f;
			 tempMove.x = knockback;
			}
			else{
			 tempMove.y = 0.1f;
			 tempMove.x = -knockback;
			}
		}
	}
	void BounceHandler(){
		doubleAnim();
		tempMove.y = 0.3f;
	}
}