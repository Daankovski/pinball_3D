using UnityEngine;
using System.Collections;

public class Flipper : MonoBehaviour {

	//Made by Danny Kruiswijk
	//This script is not being used anymore, please ignore

	[SerializeField] private float speed = 15.0f;
	private float DoorOpenAngle = -90.0f;
	private bool open;
	private Vector3 defaultRot;
	private Vector3 openRot;
	
	void Start(){
		defaultRot = transform.eulerAngles;
		openRot = new Vector3 (defaultRot.x, defaultRot.y + DoorOpenAngle, defaultRot.z);
	}

	void FixedUpdate (){
		if(open){
			transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, Time.deltaTime * speed);
		}else{
			transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, defaultRot, Time.deltaTime * speed);
		}
		if (Input.GetKey ("space")) {
			open = true;
		} else {
			open = false;
		}
	}
}