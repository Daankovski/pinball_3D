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
	private float flagYValue;
	private bool flagRaise = false;
	private GameObject flagObject;
	
	void Start () {
		flagObject = GameObject.Find ("Flag");
		flagYValue = flagObject.transform.position.y;
		xValue = transform.position.x;
		yValue = transform.position.y;
	}

	public int scoreGetter(){
		return score;
	}

	//Score +10
	public void addScore10(){
		score += 10;
		textMesh.text = "Score: " + score;
	}
	void Update(){
		transform.position = new Vector3 (xValue,yValue,transform.position.z);
		//Ending the game if there are no balls left found on the screen
		if (GameObject.Find ("Ball") || GameObject.Find ("ExtraBall") || GameObject.Find ("ExtraBall(Clone)")) {
			isEnd = false;
		} else {
			isEnd = true;
		}
		if(isEnd){
			Application.LoadLevel("End");
		}
		//Moving the camera at the start
		if(transform.position.x >= 158.3f){
			xValue -= 0.2f;
			yValue -= 0.2f;
		}
		//Raising a flag once a score of 150 has been reached
		if(score == 150){
			flagRaise = true;
		}
		if(flagRaise && flagObject.transform.position.y <= 172.03f){
			flagYValue += 0.1f;
			flagObject.transform.position = new Vector3 (flagObject.transform.position.x,flagYValue,flagObject.transform.position.z);
		}
	}
}