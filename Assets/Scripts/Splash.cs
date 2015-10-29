using UnityEngine;
using System.Collections;
using System;

public class Splash : MonoBehaviour {

	//Made by Danny Kruiswijk

	void Start () {
		StartCoroutine("ChangeScreen");
		transform.position = new Vector3(-35, 1, 0);
	}

	//Changing the 'Blue screen' after 4 seconds
	IEnumerator ChangeScreen()
	{
		yield return new WaitForSeconds(4);
		Application.LoadLevel("Leaderboards");
	}
}