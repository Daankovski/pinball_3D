using UnityEngine;
using System.Collections;

public class Pusher : MonoBehaviour {
	private Rigidbody _rigidbody;
	private Vector3 _position;
	private Vector3 initialPosition;
	[SerializeField]
	private float _speed = 0f;
	
	void Start () {
		initialPosition = transform.position;
		_rigidbody = GetComponent<Rigidbody> ();
	}

	void FixedUpdate () {
		Debug.Log (initialPosition);
		_position = new Vector3 (_speed,0f,0f);
		_rigidbody.AddForce (_position*-_speed*Time.deltaTime);
		if (Input.GetKey ("space")) {
			_speed = 100f;
		}
		else{
			_speed = 0f;
			_rigidbody.position = initialPosition;
		}
	}
}
