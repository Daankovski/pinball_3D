using UnityEngine;
using System.Collections;

public class FloatingObject : MonoBehaviour {

	//Made by Danny Kruiswijk

    private float count = 0f;
    private int number = 0;
    private float timer = 0.0f;
    private float verticalSpeed = 1.0f;
    private float verticalDistance = 1.0f;
	private Light light;
	
	void Start () {
		light = GetComponentInChildren<Light> ();
	}

	void FixedUpdate () {
		light.color = new Color (Random.Range(0,255),Random.Range(0,255),Random.Range(0,255));
	    if(count < Mathf.PI && number == 0){
	        count += Time.deltaTime;
	    }
	    if(count >= Mathf.PI){
		    number = 1;
	   	}
	    if(count <= 0){
		    number = 0;
		}
	    if(count >= 0 && number == 1){
	        count = 0;
	    }	
	    GetComponent<Rigidbody>().velocity = new Vector3(0f, Mathf.Sin(2*count*verticalSpeed)*verticalDistance, 0);
	}
}