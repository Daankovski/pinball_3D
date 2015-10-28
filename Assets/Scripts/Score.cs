using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	//Made by Danny Kruiswijk

	private int score;
	[SerializeField] private TextMesh textMesh;
	private bool isEnd = false;
	private float xValue;
	private float yValue;

	// Use this for initialization
	void Start () {
		xValue = transform.position.x;
		yValue = transform.position.y;
	}

	public void addScore10(){
		score += 10;
		textMesh.text = "Score: " + score;
	}
	void Update(){
		transform.position = new Vector3 (xValue,yValue,transform.position.z);
		if (GameObject.Find ("Ball") || GameObject.Find ("ExtraBall") || GameObject.Find ("ExtraBall(Clone)") || GameObject.Find ("ExtraBall (1)")) {
			isEnd = false;
		} else {
			isEnd = true;
		}
		if(isEnd == true){
			Application.LoadLevel("End");
		}
		if(transform.position.x >= 158.3f){
			xValue -= 0.2f;
			yValue -= 0.2f;
		}
	}
}