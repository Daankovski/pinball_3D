﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	//Made by Danny Kruiswijk

	[HideInInspector] public Rigidbody myRigidbody;
	private Vector3 oldVel;
	private GameObject cameraObject;
	private Score score;
	[HideInInspector] public Vector3 initialPosition;
	private TrailRenderer trail;
	
	void Start () {
		myRigidbody = GetComponent<Rigidbody>();
		trail = GetComponent<TrailRenderer> ();
		cameraObject = GameObject.Find ("Main Camera");
		score = cameraObject.GetComponent<Score>();
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
		if (myRigidbody.position.y != 172.7f) {
			myRigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
		} else {
			myRigidbody.constraints = RigidbodyConstraints.None;
			myRigidbody.constraints = RigidbodyConstraints.FreezePositionY;
		}
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