using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDShow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.SetActive(false);
		CloseStart.showHUD += showHUDHandler;
	}
	void showHUDHandler(){
		gameObject.SetActive(true);
	}
}
