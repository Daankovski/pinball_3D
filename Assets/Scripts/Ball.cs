using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	//Made by Danny Kruiswijk

	private Rigidbody myRigidbody; 
	private Vector3 oldVel;
	private GameObject cameraObject;
	private Score score;
	private Vector3 initialPosition;
	private TrailRenderer trail;
	
	void Start () {
		myRigidbody = GetComponent<Rigidbody>();
		trail = GetComponent<TrailRenderer> ();
		cameraObject = GameObject.Find ("Main Camera");
		score = cameraObject.GetComponent<Score>();
		initialPosition = transform.position;
	}

	//Get Trail
	public float getterTrail(){
		return trail.time;
	}

	//Set Trail
	public void setterTrail(float time){
		trail.time = time;
	}

	//Get Rigidbody
	public Rigidbody getterRigidBody(){
		return myRigidbody;
	}

	//Set Rigidbody
	public void setterRigidBody(Rigidbody value){
		myRigidbody = value;
	}

	//Remove Trail
	public void removeTrail(){
		trail.time = 0;
	}
	
	void FixedUpdate() {
		oldVel = myRigidbody.velocity;
		//When falling from the rocket
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
			myRigidbody.velocity += cp.normal*20.0f;
		}
	}
}