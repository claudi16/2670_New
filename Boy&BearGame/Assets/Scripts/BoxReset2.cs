using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BoxReset2 : MonoBehaviour {

	public GameObject resetPoint2;//For Color Puzzle
	Vector3 originalPosition;

	void Start(){
		GameOver.resetAll += resetBox;
		originalPosition = gameObject.transform.position;
	}

	void OnTriggerEnter(Collider touch)
	{
		if(touch.gameObject.tag == "ResetFall" || touch.gameObject.tag == "BoxResetTouch"){	
		transform.position = originalPosition;
		gameObject.SetActive(false);
		Invoke("resetBox", 0.6f);
		}
		if(touch.gameObject.tag == "BoxResetTouchSpecial"){ //Color Puzzle
		gameObject.transform.position = resetPoint2.transform.position;
		gameObject.SetActive(false);
		Invoke("resetBox2", 0.6f);
		}
	}
	void resetBox(){ //Reappear
		gameObject.SetActive(true);
		gameObject.transform.position = originalPosition;
	}
	void resetBox2(){//Reappear Color Puzzle
		gameObject.SetActive(true);
		gameObject.transform.position = resetPoint2.transform.position;
	}
}
