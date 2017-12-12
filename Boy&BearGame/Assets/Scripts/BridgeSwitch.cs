using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeSwitch : MonoBehaviour {

	void Start(){
		gameObject.SetActive(false);
		JumpTrigger.Bridge2 += BrokenBridge;
	}
	void BrokenBridge(){
		gameObject.SetActive(true);
	}
}
