using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CloseStart : MonoBehaviour {
	public static UnityAction showHUD;

	public void CloseSplash(){
	showHUD();
	GameObject.Find("StartScreen").SetActive(false);
	}
}
