using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BerryCounterText : MonoBehaviour {
	public Text counterText;

	void Start () {
	ResetAll.resetBerries += resetBerriesHandler;
	counterText.text = ("   x " + SVars.berryCount);	
	PickUpCounter.berryCountAct += berryCountActHandler;
	}
	
	void berryCountActHandler(){
	counterText.text = ("   x " + SVars.berryCount);
	}
	void resetBerriesHandler(){
	SVars.berryCount = 0;
	counterText.text = ("   x " + SVars.berryCount);
	}
}
