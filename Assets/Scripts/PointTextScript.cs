using UnityEngine;
using System.Collections;

public class PointTextScript : MonoBehaviour {

	private float yValue;

	// Use this for initialization
	void Start () {
		yValue = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		yValue += 0.075f;
		transform.position = new Vector3 (transform.position.x,yValue,transform.position.z);
		if(yValue >= 177.5f){
			GameObject.Destroy(gameObject);
		}
	}
}
