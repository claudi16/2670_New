using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveLightExit : MonoBehaviour {
	public GameObject light;
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
	}

}
