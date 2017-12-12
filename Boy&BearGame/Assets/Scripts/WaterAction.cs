using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WaterAction : MonoBehaviour {
	public static UnityAction TempVars;
	public static UnityAction TempVarsOff;
	public static UnityAction EnemyChase;
	public static UnityAction SwimAnim;

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