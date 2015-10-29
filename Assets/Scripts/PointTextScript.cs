using UnityEngine;
using System.Collections;

public class PointTextScript : MonoBehaviour {

	//Made by Danny Kruiswijk

	private float yValue;
	
	void Start () {
		yValue = transform.position.y;
	}

	//The 10 point text above Bumpers
	void Update () {
		yValue += 0.075f;
		transform.position = new Vector3 (transform.position.x,yValue,transform.position.z);
		if(yValue >= 177.5f){
			GameObject.Destroy(gameObject);
		}
	}
}
