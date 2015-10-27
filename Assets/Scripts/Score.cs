using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	//Made by Danny Kruiswijk

	private int score;
	[SerializeField] private TextMesh textMesh;
	private bool isEnd = false;

	// Use this for initialization
	void Start () {

	}

	public void addScore10(){
		score += 10;
		textMesh.text = "Score: " + score;
	}
	void Update(){
		if (GameObject.Find ("Ball") || GameObject.Find ("ExtraBall") || GameObject.Find ("ExtraBall(Clone)") || GameObject.Find ("ExtraBall (1)")) {
			isEnd = false;
		} else {
			isEnd = true;
		}
		if(isEnd == true){
			Application.LoadLevel("End");
		}
	}
}