using UnityEngine;
using System.Collections;

public class CollisionColor : MonoBehaviour {

	private Renderer rend;
	private Color color;

	void Start () {
		rend = GetComponent<Renderer> ();
	}

	void Update () {
		color = new Color (Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));
	}

	void OnCollisionEnter (Collision c) {
		rend.material.color = color;
	}
}