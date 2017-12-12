using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointCharReset : MonoBehaviour {
	public GameObject Checkpoint;

	void Start(){
	HealthHarm.CheckpointChar += CheckpointSet;
	}

	void CheckpointSet(){
	transform.position = Checkpoint.transform.position;
	}
}
