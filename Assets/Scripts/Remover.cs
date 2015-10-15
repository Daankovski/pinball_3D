using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Remover : MonoBehaviour {

	private int lives = 5;
	private Vector3 ballPosition;
	[SerializeField] private List<GameObject> myPrefabs = new List<GameObject>();

	//Made by Danny Kruiswijk
	
	void Start () {
		ballPosition = GameObject.Find ("Ball").transform.position;
	}

	void Update () {

	}

	void SpawnBall(){
		GameObject ballSpawn = (GameObject)Instantiate(myPrefabs[0], new Vector3(ballPosition.x,ballPosition.y,ballPosition.z), transform.rotation);
	}

	void OnCollisionEnter (Collision other) {
		if (other.transform.tag == "Ball") {
			Destroy(other.gameObject);
			lives --;
			//Sound
			switch (lives) {
			case 4:
				Destroy(GameObject.Find("UIBall5"));
				SpawnBall();
				break;
			case 3:
				Destroy(GameObject.Find("UIBall4"));
				SpawnBall();
				break;
			case 2:
				Destroy(GameObject.Find("UIBall3"));
				SpawnBall();
				break;
			case 1:
				Destroy(GameObject.Find("UIBall2"));
				SpawnBall();
				break;
			case 0:
				Destroy(GameObject.Find("UIBall1"));
				break;
			}
		}
	}
}