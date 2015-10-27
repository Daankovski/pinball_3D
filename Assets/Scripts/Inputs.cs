using UnityEngine;
using System.Collections;


public class Inputs : MonoBehaviour {

    [SerializeField]
    private TestFlipper _flipperL;
    [SerializeField]
    private TestFlipper _flipperR;
    [SerializeField]
    private Pusher _pusher;

    void Awake() {
        _pusher = GetComponentInChildren<Pusher>();
    }

    void FixedUpdate () { 
        keyBoardLayout1();
    }

    void keyBoardLayout1()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.JoystickButton0))
        {
            if (_pusher._Speed < 60 || _pusher._Speed < 140)
            {
                _pusher.OnKeyDown = true;

            }

        }
        else
        {

            _pusher.OnKeyDown = false;
            _pusher.Mass = 1f;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.Keypad4) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.JoystickButton4))
        {
            _flipperL.LeftFlipper = true;
        }

        else
        {
            _flipperL.LeftFlipper = false;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.Keypad6) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.JoystickButton5))
        {
            _flipperR.RightFlipper = true;


        }
        else
        {
            _flipperR.RightFlipper = false;
        }

    }
}
