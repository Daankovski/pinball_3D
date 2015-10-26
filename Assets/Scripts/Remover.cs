using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Remover : MonoBehaviour {

	//Made by Danny Kruiswijk

	private int lives = 3;
	private Vector3 ballPosition;
	[SerializeField] private Ball ball;

	void Start () {
		ballPosition = GameObject.Find ("Ball").transform.position;
	}

	void OnCollisionEnter (Collision other) {
		if (other.transform.tag == "Ball") {
			lives --;
			//Sound
			switch (lives) {
			case 2:
				Destroy (GameObject.Find ("UIBall3"));
				break;
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
			if (lives > -1) {
				float time = ball.getTrail ();
				ball.removeTrail ();
				ball.myRigidbody.position = ball.initialPosition;
				ball.myRigidbody.velocity = new Vector3 (0f, 0f, 0f);
				StartCoroutine (MyMethod (time));
			}
		} else if (other.transform.tag == "ExtraBall") {
			Destroy(other.gameObject);
		}
	}

	IEnumerator MyMethod(float time) {
			yield return new WaitForSeconds (1);
			ball.setTrail (time);
	}
}

