using UnityEngine;
using System.Collections;

public class Flipper : MonoBehaviour {
	[SerializeField]
	private float speed = 15.0f;
	private float DoorOpenAngle = -90.0f;
	private bool open;
	private Vector3 defaultRot;
	private Vector3 openRot;
	
	void Start(){
		//Physics.gravity = new Vector3(0, -100.0F, 0);
		defaultRot = transform.eulerAngles;
		openRot = new Vector3 (defaultRot.x, defaultRot.y + DoorOpenAngle, defaultRot.z);
	}

	void FixedUpdate (){
		//this.GetComponent<Rigidbody> ().centerOfMass ();
		//Debug.DrawRay (this.transform.position, transform.forward, Color.red);
		//this.GetComponent<Rigidbody> ().AddForce (transform.forward * speed, ForceMode.Impulse);
		//this.GetComponent<Rigidbody> ().AddForce ((transform.forward * speed)* -1, ForceMode.Impulse);
		if(open){
			transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, Time.deltaTime * speed);
		}else{
			transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, defaultRot, Time.deltaTime * speed);
		}
		
	}
}