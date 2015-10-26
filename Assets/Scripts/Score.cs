using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	//Made by Danny Kruiswijk

	private int score;
	[SerializeField] private Text text;

	// Use this for initialization
	void Start () {
	
	}

	public void addScore10(){
		score += 10;
		text.text = "Score: " + score;
	}
}