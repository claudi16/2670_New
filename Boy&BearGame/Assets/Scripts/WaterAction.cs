using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WaterAction : MonoBehaviour {
	public static Action TempVars;
	public static Action TempVarsOff;
	public static Action EnemyChase;
	public static Action SwimAnim;

	void OnTriggerStay(){
		SVars.inWater = true;
		TempVars();
		EnemyChase();
		SwimAnim();
	}
	void OnTriggerExit(){
		SVars.inWater = false;
		SwimAnim();
		SVars.jumpScore = 0;
		TempVarsOff();
	}
}