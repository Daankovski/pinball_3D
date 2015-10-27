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
        _flipperL = GetComponent<TestFlipper>();
        _flipperR = GetComponent<TestFlipper>();
        _pusher = GetComponentInChildren<Pusher>();
    }

    void Update () { 
        keyBoardLayout1();
        keyBoardLayout2();
        keyBoardLayout3();
    }

    void keyBoardLayout1() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _pusher.FixedUpdate();
            if (_pusher._speed < 60 || _pusher._speed < 140)
            {
                _pusher.isPositive = true;
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {

           _pusher.isPositive = false;

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("left arrow was pressed");

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("right arrow was pressed");
        }

    }

    void keyBoardLayout2() {
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            print("numpad 4 is pressed");
        }

        else if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            print("numpad 6 is pressed");
        }
    }

    void keyBoardLayout3() {
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("A is pressed");
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            print("D is pressed");
        }
    }


}
