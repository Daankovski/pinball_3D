using UnityEngine;
using System.Collections;

public class Flipper : MonoBehaviour {

    private float fJumpPower = 5.5f;
    private bool isJumping = false;


    public void Jump() {
        print("Jump = " + fJumpPower);
        isJumping = true;
    }

}
