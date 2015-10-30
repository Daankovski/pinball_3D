using UnityEngine;
using System.Collections;

public class DishScript : MonoBehaviour {

	//Made by Danny Kruiswijk
	//This script is not being used anymore, please ignore

	private Renderer rend;
	private Renderer otherRend;
	
	void Start () {
		rend = GetComponent<Renderer> ();
		otherRend = GetComponentInParent<Renderer> ();
	}

	void Update () {
		rend.material.color = otherRend.material.color;
	}
}
