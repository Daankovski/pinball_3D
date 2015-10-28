using UnityEngine;
using System.Collections;
using System;

public class Splash : MonoBehaviour {
	void Start () {
		StartCoroutine("ChangeScreen");
		transform.position = new Vector3(-35, 1, 0);
	}
	
	IEnumerator ChangeScreen()
	{
		yield return new WaitForSeconds(4);
		Application.LoadLevel("Leaderboards");
	}
}