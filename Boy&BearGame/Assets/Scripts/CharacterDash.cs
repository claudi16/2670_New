using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDash : MonoBehaviour {
	CharacterController cc;
	int dashSpeed = 20;
	void Start(){
		CharacterInput.Dash += DashHandler;
	}
	void DashHandler(){
		SVars.speed = dashSpeed;			
		Invoke("DashHandlerEnd", 0.1f);
		}

	void DashHandlerEnd(){
		SVars.speed = SVars.normSpeed;
	}

}
