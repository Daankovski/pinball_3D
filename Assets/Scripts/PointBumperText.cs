﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PointBumperText : MonoBehaviour {

	//Made by Danny Kruiswijk

	[SerializeField] private List<GameObject> prefabs = new List<GameObject>();
	private Quaternion rotation = Quaternion.Euler(0, 270, 0);

	void Start () {

	}

	void Update () {

	}

	void OnCollisionEnter (Collision c) {
		GameObject pointTextSpawn = (GameObject)Instantiate(prefabs[0], new Vector3(transform.position.x,transform.position.y + 1.5f,transform.position.z - 0.94f),rotation);
	}
}