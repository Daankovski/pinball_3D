using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	//Made by Danny Kruiswijk

	Rigidbody myRigidbody;
	Vector3 oldVel;
	
	void Start () {
		myRigidbody = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate() {
		oldVel = myRigidbody.velocity;
	}

	//When you hit a bumper
	void OnCollisionEnter (Collision c) {
		if(c.transform.tag == "Bumper"){
			ContactPoint cp = c.contacts[0];
			myRigidbody.velocity = Vector3.Reflect(oldVel,cp.normal);
			//Move
			myRigidbody.velocity += cp.normal*20.0f;
			//Sound
			//Score
		}
	}
}