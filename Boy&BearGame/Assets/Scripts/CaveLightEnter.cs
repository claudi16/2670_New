using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveLightEnter : MonoBehaviour {
	public GameObject light;
	float counter = 0;
	void OnTriggerEnter(){
		StartCoroutine(Dim());
		//light.transform.rotation = Quaternion.Euler(137,0,0);
	}
	IEnumerator Dim(){
		while(counter < 137){
			counter++;
			light.transform.rotation *= Quaternion.Euler(1,0,0);
			yield return new WaitForFixedUpdate();
		}
	}

}
