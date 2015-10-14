using UnityEngine;
using System.Collections;


public class KeyInputs : MonoBehaviour {

    public TestFlipper _flipper;
    public Pusher _pusher;

    void Awake() {
        _flipper = GetComponent<TestFlipper>();
        _pusher = GetComponentInChildren<Pusher>();
    }

    void Update () { 
        keyBoardLayout1();
        keyBoardLayout2();
        keyBoardLayout3();
    }

    void keyBoardLayout1() {
        if (Input.GetKey(KeyCode.Space))
        {
            pusherSettings();
        }
        else
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

    void pusherSettings() {
        _pusher.FixedUpdate();
        if (_pusher._speed > -100)
        {
            _pusher.isPositive = true;
            _pusher._speed -= 2.5f;
        }
    }

}
