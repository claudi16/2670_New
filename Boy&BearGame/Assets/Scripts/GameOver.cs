using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class GameOver : MonoBehaviour {
	public static UnityAction resetAll;
	void Start(){
		CharacterHealth.ResetGame += ResetGameHandler;
	}
	public void ResetGameHandler(){
		resetAll();
	}
}
