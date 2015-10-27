using UnityEngine;
using System.Collections;

public class TestFlipper : MonoBehaviour {

	//Made by Danny Kruiswijk
	
	private float speed = 600f;

    private bool leftFlipper = false;
    private bool rightFlipper = false;

    void Start () {
		this.GetComponent<Rigidbody> ().centerOfMass = new Vector3 (0f,1);
		var game = new GameObject ();
		game.transform.SetParent (this.transform);
		game.transform.localPosition = this.GetComponent<Rigidbody> ().centerOfMass/2;
	}

    // Getters & Setters
        public bool LeftFlipper {
            get { return leftFlipper; }
            set { leftFlipper = value; }
        }

        public bool RightFlipper
        {
            get { return rightFlipper; }
            set { rightFlipper = value; }
        }
    //

    void FixedUpdate () {
		Debug.DrawRay (this.transform.position, transform.forward,Color.blue);
		Debug.DrawRay (this.GetComponent<Rigidbody>().worldCenterOfMass,Vector3.up,Color.red);
		switch(gameObject.tag){
		case "FlipperLeft":
			if (leftFlipper) {
				this.GetComponent<Rigidbody> ().AddForce (transform.forward * -speed, ForceMode.Impulse);
			} else {
				this.GetComponent<Rigidbody> ().AddForce (transform.forward * speed, ForceMode.Impulse);
			}
			break;
		case "FlipperRight":
			if (rightFlipper) {
				this.GetComponent<Rigidbody> ().AddForce (transform.forward * speed, ForceMode.Impulse);
			} else {
				this.GetComponent<Rigidbody> ().AddForce (transform.forward * -speed, ForceMode.Impulse);
			}
			break;
		}
	}
}
