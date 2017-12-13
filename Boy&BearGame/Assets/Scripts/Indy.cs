using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indy : MonoBehaviour {

	void OnCollisionEnter(Collision other)
	{
		if(other.collider.tag == "PlatformResetFall"){
		gameObject.SetActive(false);
		}
	}
}
