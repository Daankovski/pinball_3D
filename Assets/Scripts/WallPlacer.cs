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
		switch (isTrigger) {
		case true:
			wall.transform.position = initialPosition;
			break;
		case false:
			wall.transform.position = new Vector3(110.19f,172.59f,-91.38f);
			break;
		}
	}

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
	/*
	void OnTriggerStay(Collider other){
		switch (other.transform.tag) {
		case "Ball":
			Debug.Log("Ball");
			isTrigger = true;
			break;
		case "ExtraBall":
			isTrigger = true;
			break;
		default:
			Debug.Log("Hallo");
			isTrigger = false;
			break;
		}
		if (other.transform.tag == "Ball" || other.transform.tag == "ExtraBall") {
			isTrigger = true;
		}
	}
	*/
}