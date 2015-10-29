using UnityEngine;
using System.Collections;

public class CollisionColor : MonoBehaviour {

	//Made by Danny Kruiswijk
	
	private Renderer rend;
	private Color color;

	void Start () {
		rend = GetComponent<Renderer> ();
	}

	//A random color everytime
	void Update () {
		color = new Color (Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));
	}

	//Giving the object a random color whenever the ball hits it
	void OnCollisionEnter (Collision c) {
		rend.material.color = color;
	}
}