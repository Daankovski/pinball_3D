using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ExtraBallSpawn : MonoBehaviour {

	//Made by Danny Kruiswijk

	[SerializeField] private List<GameObject> prefabs = new List<GameObject>();
	[SerializeField] private TextMesh textMesh;
	private ParticleSystem particleSystem;
	private bool canSpawn = true;
	private int timer = 1000;
	private float zValue;
	private bool goRight = false;
	
	void Start () {
		zValue = textMesh.transform.position.z;
		particleSystem = GetComponentInChildren<ParticleSystem> ();
	}

	void FixedUpdate () {
		textMesh.transform.position = new Vector3(textMesh.transform.position.x,textMesh.transform.position.y,zValue);
		if (canSpawn == false) {
			timer --;
		}
		if(timer <= 1){
			timer = 1000;
			canSpawn = true;
		}
		if (goRight == true) {
			zValue += 1f;
		}
		if (textMesh.transform.position.z >= 0) {
			goRight = false;
			zValue = -190f;
		}
	}

	void OnCollisionEnter (Collision c) {
		if(c.transform.tag == "Ball" && canSpawn == true){
			GameObject extraBallSpawn = (GameObject)Instantiate(prefabs[0], new Vector3(106.08f,172.73f,-102.58f), transform.rotation);
			particleSystem.Play();
			goRight = true;
			canSpawn = false;
		}
	}
}