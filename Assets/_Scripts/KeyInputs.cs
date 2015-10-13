using UnityEngine;
using System.Collections;


public class KeyInputs : MonoBehaviour {

    public Flipper _flipper;

    void Awake() {
        _flipper = GetComponent<Flipper>();
    }
    
    void Start() {
        
    }


    void Update () { 
        keyBoardLayout1();
        keyBoardLayout2();
        keyBoardLayout3();
    }

    void keyBoardLayout1() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("space key was pressed");
            _flipper.Jump();

            
        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("left arrow was pressed");
            
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
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
