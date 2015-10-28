using UnityEngine;
using System.Collections;

public class DishScript : MonoBehaviour {

	//Made by Danny Kruiswijk

	private Renderer rend;
	private Renderer otherRend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		otherRend = GetComponentInParent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		rend.material.color = otherRend.material.color;
	}
}
