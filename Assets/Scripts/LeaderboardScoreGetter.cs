using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class LeaderboardScoreGetter : MonoBehaviour {

	private Text nameBoard;
	private Text scoreBoard;
	private GameObject nameObject;
	private GameObject scoreObject;
	private phpSender sender;
	private List<string> scorelist = new List<string>();
	private string displayName = "";
	private string displayScore = "";
	
	void Start () {
		sender = GameObject.Find ("PHPScoreScript").GetComponent<phpSender>();
		nameObject = GameObject.Find ("LeaderboardName");
		scoreObject = GameObject.Find ("LeaderboardScore");
		nameBoard = nameObject.GetComponent<Text>();
		scoreBoard = scoreObject.GetComponent<Text>();
		scorelist = sender.getCurrentScoreList;
		Debug.Log (scorelist.Count);

		foreach (string score in scorelist) {
			string[] lijn = score.Split(',');
			displayName += lijn[0].ToString() + "\n";
			displayScore += lijn[1].ToString() + "\n";
		}
		nameBoard.text = displayName;
		scoreBoard.text = displayScore;
	}

	void Update () {
	
	}
}
