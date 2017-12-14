using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour {
	public GameObject youWinText;
	void Start () {
		youWinText.SetActive(false);
	}
	void OnTriggerEnter(){
		youWinText.SetActive(true);
	}
	
}
