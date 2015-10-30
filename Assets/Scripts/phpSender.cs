using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class phpSender : MonoBehaviour {
	public string url = "http://localhost/pinball/phpscript.php"; // url veranderen naar php-script url
    Score scoreKeeper;
    List<string> scorelist = new List<string>();
	private int tempScore;
	private ChangeLevel sender;
	private string tempName;
	private GameObject nameObject;

	void Start () {
		nameObject = GameObject.Find ("Name Holder");
		sender = nameObject.GetComponent<ChangeLevel> ();
		tempName = sender.nameGetter ();
        scoreKeeper = GameObject.Find("Main Camera").GetComponent<Score>(); // object die score/string bijhoud(Pakt getter en setter vanaf deze var!)
	}

	void Update () {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            startSendingProcess();   
        }
        if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            for (int i = 0; i < scorelist.Count; i++)
            {
                Debug.Log(scorelist[i]);
            }
        }
	}

    IEnumerator WaitForRequest(WWW www)
    {
        yield return www;

       foreach(string line in www.text.Split('\n'))
       {
           scorelist.Add(line);
       }       
    }

    public void startSendingProcess() // callen om score te verzenden/op te halen
    {
		tempScore = scoreKeeper.scoreGetter ();
        string scorestring = (tempScore.ToString() + "," + tempName); //verander tempname naar een ge-gette string playername
        WWWForm score = new WWWForm();
        score.AddField("score", scorestring);
        WWW w = new WWW(url, score);
        StartCoroutine(WaitForRequest(w)); // deze functie om op te halen van scores te beginnen
    }
    public List<string> getCurrentScoreList // returned huidige score lijst
    {
        get
        {
            return scorelist;
        }
    }
}