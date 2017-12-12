using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bear : MonoBehaviour {
	//public static UnityAction End;

	void OnTriggerEnter()	{ 
		if(SVars.pickupCounter <=2){
			//End();
		}
		if(SVars.pickupCounter == 3){
			print("You may pass");
		}
	}
}
