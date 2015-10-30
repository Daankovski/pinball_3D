using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Remover : MonoBehaviour {

	//Made by Danny Kruiswijk

	private int lives = 2;
	private Vector3 ballPosition;
	[SerializeField] private Ball ball;
	private AudioSource audioSource;
	private Rigidbody otherRigidBody;

	void Start () {
		//Initial ball position
		ballPosition = new Vector3 (136.47f,172.7f,-91.29f);
		audioSource = GetComponent<AudioSource> ();
	}

	//Whenver the invisible remove wall is hit
	void OnCollisionEnter (Collision other) {
		otherRigidBody = ball.getterRigidBody ();
		audioSource.Play ();
		if (other.transform.tag == "Ball") {
			lives --;
			//Remove the 'Balls left' UI
			switch (lives) {
			case 1:
				Destroy (GameObject.Find ("UIBall2"));
				break;
			case 0:
				Destroy (GameObject.Find ("UIBall1"));
				break;
			case -1:
				Destroy (GameObject.Find ("Ball"));
				break;
			}
			//When out of balls
			if (lives > -1) {
				float time = ball.getterTrail ();
				ball.removeTrail ();
				otherRigidBody.position = ballPosition;
				otherRigidBody.velocity = new Vector3 (0f, 0f, 0f);
				ball.setterRigidBody(otherRigidBody);
				StartCoroutine (MyMethod (time));
			}
		} else if (other.transform.tag == "ExtraBall") {
			Destroy(other.gameObject);
		}
	}

	//Removing the trail and reapplying when the ball gets teleported
	IEnumerator MyMethod(float time) {
			yield return new WaitForSeconds (1);
			ball.setterTrail (time);
	}
}