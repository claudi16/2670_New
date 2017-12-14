using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SVars : MonoBehaviour {

	public static float speed = 5f;//2.8 //5
	public static float normSpeed = 5f;
	public static float gravity = 0.7f;//1 //0.7
<<<<<<< Updated upstream
	public static float jumpHeight = 0.3f;//0.3 //0.2
	public static float jumpHeightWater = 0.15f;
=======
	public static float jumpHeight = 0.37f;//0.3 //0.2
	public static float jumpHeightWater = 0.2f;//.15
>>>>>>> Stashed changes
	public static float jumpScore = 0;
	public static bool inWater = false;
	public static int healthCounter = 0;
	public static int berryCount = 0;
	public static int pickupCounter = 0;
	public static int blinks = 0;
	public static bool jump = true;
}