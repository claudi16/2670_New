using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyKill : MonoBehaviour {
	public GameObject particles;
	public GameObject enemy;
	public static UnityAction Bounce;
	void Start(){
		particles.SetActive(false);
	}
	void OnTriggerEnter(){
		//transform.parent.gameObject.SetActive(false);
		particles.SetActive(true);		
		Bounce();
		transform.gameObject.GetComponent<Collider>().enabled = false;
		transform.parent.gameObject.GetComponent<Collider>().enabled = false;	
		enemy.transform.rotation *= Quaternion.Euler(0,0,180);
		Invoke("EnemyDeath", 1);
	}
	void EnemyDeath(){
		transform.parent.gameObject.SetActive(false);
	}
}
