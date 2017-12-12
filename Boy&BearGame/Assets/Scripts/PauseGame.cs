using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PauseGame : MonoBehaviour {
	public static UnityAction pauseMenu;
	public void Pause(){
		SVars.jump = false;
		pauseMenu();
	 	Time.timeScale = 0;
	}
}
