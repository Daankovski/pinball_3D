using UnityEngine;
using System.Collections;

public class Pusher : MonoBehaviour {

	//Made by Danny Kruiswijk
	
	private Rigidbody _rigidbody;
	private Vector3 _position;
	private Vector3 initialPosition;
	private float _speed = 0f;
	
	void Start () {
		initialPosition = transform.position;
		_rigidbody = GetComponent<Rigidbody> ();
	}

	//Making the spring move backwards and push the ball forward
	void FixedUpdate () {
		_position = new Vector3 (_speed,0f,0f);
		_rigidbody.AddForce (_position*-_speed*Time.deltaTime);
		if (Input.GetKey ("space")) {
			_speed = Random.Range(30,140);
		}
		else{
			//Returning it back
			_speed = 0f;
			_rigidbody.position = initialPosition;
		}
	}
}
