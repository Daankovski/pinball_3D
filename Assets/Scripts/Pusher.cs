using UnityEngine;
using System.Collections;

public class Pusher : MonoBehaviour {

    //Made by Danny Kruiswijk

    private Rigidbody _rigidbody;
    private BoxCollider _boxCollider;
    private GameObject _SpringObject;
    private Vector3 _position;
    private Vector3 initialPosition;
    private bool onKeyDown = false;

    private float xSpringScale;
    private float xSpringPos;
    private float f_boxScale;
    private float f_boxCenter;

    private float _speed = 0f;
    private float mass = 0f;
    private int num;
	
	void Start () {
		initialPosition = transform.position;
		_rigidbody = GetComponent<Rigidbody> ();
        _boxCollider = GetComponent<BoxCollider>();
        _SpringObject = GameObject.Find("Spring");
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

        _boxCollider.size = new Vector3(f_boxScale, 1.5f, 1.5f);
        _boxCollider.center = new Vector3(f_boxCenter, -0.62f, 1f);
        _SpringObject.transform.localScale = new Vector3(xSpringScale, 1f, 1f);
        _SpringObject.transform.localPosition = new Vector3(xSpringPos, -0.69f, 0.98f);

        switch (onKeyDown) { 
            case true:
                num = 1;
                _speed = 6f;

                if (xSpringScale > 0.4f)
                {
                    xSpringScale -= 0.002f;
                }

                if (f_boxScale > 2.79) {
                    f_boxScale -= 0.02f;
                    f_boxCenter -= 0.02f;                }
                
                break;

            case false:
                num = -1;
                _speed = Random.Range(30, 140);
                xSpringScale = 0.8f;
                xSpringPos = 4.81f;
                f_boxScale = 8.8f;
                f_boxCenter = 5.08f;
                break;
        }

        if (transform.position == initialPosition)
        {
            _speed = 0f;
            _rigidbody.mass = 5f;
        }
        
	}

    
}
