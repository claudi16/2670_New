using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CaveLightEnter : MonoBehaviour {
	public static UnityAction fadeInAnim;
	public static UnityAction fadeOutAnim;
	void OnTriggerEnter(){
		fadeInAnim();
	}
	void OnTriggerExit(){
		fadeOutAnim();
	}
	/*public GameObject light;
	float counter = 0;
	void OnTriggerEnter(){
		StartCoroutine(Lighten());
		//light.transform.rotation = Quaternion.Euler(137,0,0);
	}
	IEnumerator Lighten(){
		while(counter < 137){
			counter++;
			light.transform.rotation *= Quaternion.Euler(-1,0,0);
			yield return new WaitForFixedUpdate();
		}
	}*/

}
