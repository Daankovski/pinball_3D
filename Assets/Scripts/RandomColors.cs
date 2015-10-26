using UnityEngine;
using System.Collections;

public class RandomColors : MonoBehaviour {

	//Made by Danny Kruiswijk
	
	private Renderer rend;
	private int randomNumber;

	void Start () {
		rend = GetComponent<Renderer>();
	}

	void FixedUpdate () {
		randomNumber = Random.Range(0,9);

		switch (randomNumber) {
		case 0:
			rend.material.color = Color.black;
			break;
		case 1:
			rend.material.color = Color.blue;
			break;
		case 2:
			rend.material.color = Color.cyan;
			break;
		case 3:
			rend.material.color = Color.gray;
			break;
		case 4:
			rend.material.color = Color.green;
			break;
		case 5:
			rend.material.color = Color.magenta;
			break;
		case 6:
			rend.material.color = Color.red;
			break;
		case 7:
			rend.material.color = Color.white;
			break;
		case 8:
			rend.material.color = Color.yellow;
			break;
		}
	}
}