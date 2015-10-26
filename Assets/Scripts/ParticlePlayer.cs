using UnityEngine;
using System.Collections;

public class ParticlePlayer : MonoBehaviour {

	//Made by Danny Kruiswijk

	private ParticleSystem PS;

	// Use this for initialization
	void Start () {
		PS = GetComponentInChildren<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision c) {
		PS.Play ();
	}
}
