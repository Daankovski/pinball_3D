using UnityEngine;
using System.Collections;

public class CirclingPlane : MonoBehaviour {

	//Made by Danny Kruiswijk

	[SerializeField] private Vector3 velocity;
	private Rigidbody rb;
	void Start() {
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate() {
		Quaternion deltaRotation = Quaternion.Euler(velocity * Time.deltaTime);
		rb.MoveRotation(rb.rotation * deltaRotation);
	}
}