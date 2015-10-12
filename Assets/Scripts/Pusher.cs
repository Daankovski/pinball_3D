using UnityEngine;
using System.Collections;

public class Pusher : MonoBehaviour {
	private Rigidbody _rigidbody;
	private Vector3 _position;
	private float x;
	private float _speed = 10f;

	// Use this for initialization
	void Start () {
		_rigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		_position = new Vector3 (x,0f,0f);
		x = Input.GetAxis ("Jump");
		_rigidbody.AddForce (_position*-_speed);
	}
}
