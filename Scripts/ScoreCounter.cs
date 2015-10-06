using UnityEngine;
using System.Collections;

public class ScoreCounter : MonoBehaviour {

    private float playerScore = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public float currentScore
    {
        get
        {
            return currentScore = playerScore;
        }
        set
        {
            playerScore = value;
        }

    }
}
