using UnityEngine;
using System.Collections;

public class Pusher : MonoBehaviour {

	private Rigidbody _rigidbody;
	private Vector3 _position;
	private Vector3 initialPosition;

    public bool isPositive = false;

	public float _speed = 0f;
    private float num;
	
	void Start () {
		initialPosition = transform.position;
		_rigidbody = GetComponent<Rigidbody> ();

	}

<<<<<<< HEAD
    public void FixedUpdate () {
		//Debug.Log (initialPosition);
		_position = new Vector3 (_speed,0f,0f);
		_rigidbody.AddForce (_position*(_speed*num)*Time.deltaTime);

        if (isPositive)
        {
            num = 1f;
        }

        else
        {
            num = -1f;
        }

        if (transform.position == initialPosition) {
            _speed = 0f;
        }



        /*
        if (Input.GetKey ("space")) {
			_speed = 100f;
=======
	void FixedUpdate () {
		_position = new Vector3 (_speed,0f,0f);
		_rigidbody.AddForce (_position*-_speed*Time.deltaTime);
		if (Input.GetKey ("space")) {
			//_speed = 100f;
			_speed = Random.Range(30,140);
>>>>>>> 569c19649911b768a102bf571829b13e0988c8d6
		}
		else{
			_speed = 0f;
			
		}
        */
    }
}
