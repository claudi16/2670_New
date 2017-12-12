using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAudio : MonoBehaviour {

	private AudioSource audio;
	public AudioClip grassWalkAudio;
	public AudioClip jumpAudio;
	public AudioClip enKillAudio;
	void Start () {
		CharacterMove.stopAudio += StopWalkAudio;
		EnemyKill.Bounce += EnemyKillAudio;
		audio = GetComponent<AudioSource>();
	}
	public void WalkAudio(){
		audio.PlayOneShot(grassWalkAudio, 0.4f);
	}
	public void StopWalkAudio(){
		audio.Stop();
	}
	public void JumpAudio(){
		audio.PlayOneShot(jumpAudio, 0.3f);
	}

	void EnemyKillAudio(){
		audio.PlayOneShot(enKillAudio, 0.5f);
	}

}
