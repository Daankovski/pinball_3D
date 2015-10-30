using UnityEngine;
using System.Collections;

public class TestFlipper : MonoBehaviour {

	//Made by Danny Kruiswijk
	
	private float speed = 600f;
	[SerializeField] private bool isLeft = false;
	private AudioSource audioSource;
	private bool leftBool = false;
	private bool rightBool = false;

	void Start () {
		this.GetComponent<Rigidbody> ().centerOfMass = new Vector3 (0f,1);
		audioSource = GetComponent<AudioSource> ();
		var game = new GameObject ();
		game.transform.SetParent (this.transform);
		game.transform.localPosition = this.GetComponent<Rigidbody> ().centerOfMass/2;
	}

	void flipperForward(){
		this.GetComponent<Rigidbody> ().AddForce (transform.forward * -speed, ForceMode.Impulse);
	}

	void flipperBackward(){
		this.GetComponent<Rigidbody> ().AddForce (transform.forward * speed, ForceMode.Impulse);
	}

	void FixedUpdate () {
		//Useful for finding where the flippers are pointed at and finding the current center of mass
		Debug.DrawRay (this.transform.position, transform.forward,Color.blue);
		Debug.DrawRay (this.GetComponent<Rigidbody>().worldCenterOfMass,Vector3.up,Color.red);
		//Playing a sound and turning the flipper once Left key is pressed
		switch(isLeft){
		case true:
			if (Input.GetKey ("left")) {
				flipperForward();
				if(leftBool == false){
					audioSource.Play();
				}
				leftBool = true;
			} else {
				flipperBackward();
				leftBool = false;
			}
			break;
		//Playing a sound and turning the flipper once Right key is pressed
		case false:
			if (Input.GetKey ("right")) {
				flipperBackward();
				if(rightBool == false){
					audioSource.Play();
				}
				rightBool = true;
			} else {
				flipperForward();
				rightBool = false;
			}
			break;
		}
	}
}
