using UnityEngine;
using System.Collections;

public class Pusher : MonoBehaviour {

	//Made by Danny Kruiswijk
	
	private Rigidbody _rigidbody;
	private Vector3 _position;
	private Vector3 initialPosition;

    [HideInInspector] //zorgt er voor dat een public niet in de inspector is te zien.
    public bool isPositive = false;
    [HideInInspector] //zorgt er voor dat een public niet in de inspector is te zien.
	public float _speed = 0f;
    private int num;
	
	void Start () {
		initialPosition = transform.position;
		_rigidbody = GetComponent<Rigidbody> ();
	}

    public void FixedUpdate () {
        _position = new Vector3(_speed, 0f, 0f);
        _rigidbody.AddForce(_position * (_speed * num) * Time.deltaTime);

        switch (isPositive) { 
            case true:
                num = 1;
                _speed = Random.Range(30, 140);
                break;

            case false:
                num = -1;
                _speed = Random.Range(30, 280);
                break;
        }

        if (transform.position == initialPosition)
        {
            _speed = 0f;
        }
	}
}
