using UnityEngine;
using System.Collections;

public class TestFlipper : MonoBehaviour {

	//Made by Danny Kruiswijk
	
	private float speed = 200f;
	[SerializeField]
	private bool isLeft = false;
	void Start () {
		this.GetComponent<Rigidbody> ().centerOfMass = new Vector3 (0f,1);
		var game = new GameObject ();
		game.transform.SetParent (this.transform);
		game.transform.localPosition = this.GetComponent<Rigidbody> ().centerOfMass/2;
	}

	void FixedUpdate () {
		//Debug.DrawRay (this.transform.position, transform.forward,Color.blue);
		//Debug.DrawRay (this.GetComponent<Rigidbody>().worldCenterOfMass,Vector3.up,Color.red);
		switch(isLeft){
		case true:
			if (Input.GetKey ("left")) {
				this.GetComponent<Rigidbody> ().AddForce (transform.forward * -speed, ForceMode.Impulse);
			} else {
				this.GetComponent<Rigidbody> ().AddForce (transform.forward * speed, ForceMode.Impulse);
			}
			break;
		case false:
			if (Input.GetKey ("right")) {
				this.GetComponent<Rigidbody> ().AddForce (transform.forward * speed, ForceMode.Impulse);
			} else {
				this.GetComponent<Rigidbody> ().AddForce (transform.forward * -speed, ForceMode.Impulse);
			}
			break;
		}
	}
}
