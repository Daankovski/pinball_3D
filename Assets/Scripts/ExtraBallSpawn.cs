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
	//private AudioSource audioSource;
	//[SerializeField] private AudioClip rocketSound;
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
		textMesh.transform.position = new Vector3(textMesh.transform.position.x,textMesh.transform.position.y,zValue);
		countdownMesh.text = ""+(timer / 100);
		if (canSpawn == false) {
			timer --;
		}
		if(timer <= 1){
			canSpawn = true;
			allowedToSpawn = true;
		}
		if (goRight == true) {
			zValue += 0.65f;
		}
		if (textMesh.transform.position.z >= 0) {
			goRight = false;
			zValue = -200f;
			audio1.Stop();
			//AudioSource.stop();
		}
		if(textMesh.transform.position.z >= -113 && allowedToSpawn){
			allowedToSpawn = false;
			GameObject extraBallSpawn = (GameObject)Instantiate(prefabs[0], new Vector3(textMesh.transform.position.x,textMesh.transform.position.y,textMesh.transform.position.z+10f), transform.rotation);
		}
	}

	void OnCollisionEnter (Collision c) {
		if(canSpawn){
			timer = 1500;
			particleSystem.Play();
			audio1.Play();
			audio2.Play();
			//AudioSource.PlayClipAtPoint(rocketSound, new Vector3(5, 1, 2));
			goRight = true;
			canSpawn = false;
		}
	}
}