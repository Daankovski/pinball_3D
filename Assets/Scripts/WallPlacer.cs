using UnityEngine;
using System.Collections;

public class WallPlacer : MonoBehaviour {

	//Made by Danny Kruiswijk
	private GameObject wall;
	private Vector3 initialPosition;
	private bool isTrigger;

	// Use this for initialization
	void Start () {
		wall = GameObject.Find ("BallWall");
		initialPosition = new Vector3 (110.19f,162.59f,-91.38f);
	}
	
	// Update is called once per frame
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
}