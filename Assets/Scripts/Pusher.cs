using UnityEngine;
using System.Collections;

public class Pusher : MonoBehaviour {

    //Made by Danny Kruiswijk

    private Rigidbody _rigidbody;
    private Vector3 _position;
    private Vector3 initialPosition;
    private bool onKeyDown = false;
    private float _speed = 0f;
    private float mass = 0f;
    private int num;
	
	void Start () {
		initialPosition = transform.position;
		_rigidbody = GetComponent<Rigidbody> ();
	}

    //Getters & Setters
    public bool OnKeyDown
    {
        get { return onKeyDown; }
        set { onKeyDown = value; }
    }

    public float _Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    public float Mass {
        get { return _rigidbody.mass; }
        set { _rigidbody.mass = value; }
    }
    //

    public void FixedUpdate () {
        _position = new Vector3(_speed, 0f, 0f);
        _rigidbody.AddForce(_position * (_speed * num) * Time.deltaTime);

        switch (onKeyDown) { 
            case true:
                num = 1;
                _speed = Random.Range(30, 140);
                break;

            case false:
                num = -1;
                _speed = Random.Range(30, 140);
                break;
        }

        if (transform.position == initialPosition)
        {
            _speed = 0f;
            _rigidbody.mass = 5f;
        }
        
	}

    
}
