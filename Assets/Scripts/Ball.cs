﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	//Made by Danny Kruiswijk

	[HideInInspector] public Rigidbody myRigidbody;
	Vector3 oldVel;
	[SerializeField] private Score score;
	[HideInInspector] public Vector3 initialPosition;
	private TrailRenderer trail;
	
	void Start () {
		myRigidbody = GetComponent<Rigidbody>();
		trail = GetComponent<TrailRenderer> ();
		initialPosition = transform.position;
	}

	public void setTrail(float time){
		trail.time = time;
	}

	public float getTrail(){
		return trail.time;
	}

	public void removeTrail(){
		trail.time = 0;
	}
	
	void FixedUpdate() {
		oldVel = myRigidbody.velocity;
	}

	//When you hit a bumper
	void OnCollisionEnter (Collision c) {
		if(c.transform.tag == "Bumper"){
			score.addScore10();
			ContactPoint cp = c.contacts[0];
			myRigidbody.velocity = Vector3.Reflect(oldVel,cp.normal);
			//Move
			myRigidbody.velocity += cp.normal*20.0f;
			//Sound
			//Score
		}
	}
}