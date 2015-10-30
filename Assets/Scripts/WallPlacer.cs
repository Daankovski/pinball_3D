using UnityEngine;
using System.Collections;

public class WallPlacer : MonoBehaviour {

	//Made by Danny Kruiswijk

	private GameObject wall;
	private Vector3 initialPosition;
	private bool isTrigger;
	
	void Start () {
		wall = GameObject.Find ("BallWall");
		initialPosition = new Vector3 (110.19f,162.59f,-91.38f);
		isTrigger = false;
	}

	void Update () {
		//Moving the small wall at the end of the spring so the balls cannot get back in
		switch (isTrigger) {
		case true:
			wall.transform.position = initialPosition;
			break;
		case false:
			wall.transform.position = new Vector3(110.19f,172.59f,-91.38f);
			break;
		}
	}

	//There is an invisible wall with a box collider that checks if a ball is currently in the shaft
	void OnTriggerEnter(Collider other) {
		if (other.transform.tag == "Ball") {
			isTrigger = true;
		}
	}
	void OnTriggerExit(Collider other){
		if(other.transform.tag == "Ball"){
			isTrigger = false;
		}
	}
}