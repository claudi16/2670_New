using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterInput : MonoBehaviour {

	public static UnityAction<float> KeyAction;
    public static UnityAction JumpAction;
    public static UnityAction JumpAnim;
    public static UnityAction Dash;
    public bool PlayerInput = true;

    public void Start(){
        StartCoroutine(CharInput());
    }
    IEnumerator CharInput(){
        while(PlayerInput){
            if  (KeyAction !=null) {
            KeyAction(Input.GetAxis("Horizontal"));
        }
             if (Input.GetKeyDown(KeyCode.Space) && SVars.jump == true) {
            JumpAction();
            JumpAnim();
        }   
             if(Input.GetKeyUp(KeyCode.C)){
            //transform.DetachChildren();	
            SVars.jumpHeight = 0.3f;
        }
             if(Input.GetKeyDown(KeyCode.D) && SVars.jumpScore >= 1){
            Dash();
        }
        yield return new WaitForSeconds(0.01f);
        }
    }
	/*void Update () {

        if  (KeyAction !=null) {
            KeyAction(Input.GetAxis("Horizontal"));
        }
        if (Input.GetKeyDown(KeyCode.Space) && SVars.jump == true) {
            JumpAction();
        }   
        if(Input.GetKeyUp(KeyCode.C)){
            transform.DetachChildren();
            SVars.jumpHeight = 0.3f;
        }
        if(Input.GetKeyDown(KeyCode.D)){
            Dash();
        }
    }*/
}