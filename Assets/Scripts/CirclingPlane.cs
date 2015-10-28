using UnityEngine;
using System.Collections;

public class CirclingPlane : MonoBehaviour {

	[SerializeField] private Vector3 eulerAngleVelocity;
	private Rigidbody rb;
	void Start() {
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate() {
		Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime);
		rb.MoveRotation(rb.rotation * deltaRotation);
	}
}