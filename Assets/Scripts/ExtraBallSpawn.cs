using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ExtraBallSpawn : MonoBehaviour {

	//Made by Danny Kruiswijk

	[SerializeField] private List<GameObject> prefabs = new List<GameObject>();
	[SerializeField] private TextMesh textMesh;
	[SerializeField] private TextMesh countdownMesh;
	private ParticleSystem particleSystem;
	private bool canSpawn = true;
	private int timer = 0;
	private float zValue;
	private bool goRight = false;
	private bool allowedToSpawn = true;
	public AudioSource[] sounds;
	public AudioSource audio1;
	public AudioSource audio2;
	
	void Start () {
		zValue = textMesh.transform.position.z;
		particleSystem = GetComponentInChildren<ParticleSystem> ();
		sounds = GetComponents<AudioSource> ();
		audio1 = sounds[0];
		audio2 = sounds[1];
	}

	void FixedUpdate () {
		//Moving the flying 'Extra ball' text on the rocket
		textMesh.transform.position = new Vector3(textMesh.transform.position.x,textMesh.transform.position.y,zValue);
		//The countdown seen on the satellite dish counting down wheter you can get an extra ball or not
		countdownMesh.text = ""+(timer / 100);
		if (canSpawn == false) {
			timer --;
		}
		if(timer <= 1){
			canSpawn = true;
			allowedToSpawn = true;
		}
		//Moving the rocket/text
		if (goRight == true) {
			zValue += 0.65f;
		}
		//Returning the rocket back to it's original position
		if (textMesh.transform.position.z >= 0) {
			goRight = false;
			zValue = -200f;
			audio1.Stop();
		}
		//Spawning and dropping the extra ball from the rocket
		if(textMesh.transform.position.z >= -113 && allowedToSpawn){
			allowedToSpawn = false;
			GameObject extraBallSpawn = (GameObject)Instantiate(prefabs[0], new Vector3(textMesh.transform.position.x,textMesh.transform.position.y,textMesh.transform.position.z+10f), transform.rotation);
		}
	}

	//Playing sounds and particle effects once the Satellite dish has been hit
	void OnCollisionEnter (Collision c) {
		if(canSpawn){
			timer = 1500;
			particleSystem.Play();
			audio1.Play();
			audio2.Play();
			goRight = true;
			canSpawn = false;
		}
	}
}