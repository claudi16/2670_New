using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterVars : MonoBehaviour {

	void Start(){
		WaterAction.TempVars += tempVarsHandler;
		WaterAction.TempVarsOff += tempVarsHandlerOff;
	}
	void tempVarsHandler(){
		SVars.speed = 5f;//3 BUILD //5
		SVars.gravity = 0.3f;//0.8  // 0.3
		SVars.jumpHeight = SVars.jumpHeightWater;
	}
	void tempVarsHandlerOff(){
		SVars.speed = 5f;
		SVars.gravity = 0.7f;
		SVars.jumpHeight = 0.3f;
	}
}
