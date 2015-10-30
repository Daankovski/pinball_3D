using UnityEngine;
using System.Collections;

public class ParticlePlayer : MonoBehaviour {

	//Made by Danny Kruiswijk

	private ParticleSystem PS;
	
	void Start () {
		PS = GetComponentInChildren<ParticleSystem> ();
	}

	//Play certain particle effects once the object has been hit by the ball
	void OnCollisionEnter (Collision c) {
		PS.Play ();
	}
}