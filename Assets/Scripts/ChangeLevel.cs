using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeLevel : MonoBehaviour {

	//Made by Danny Kruiswijk

	private Text text;
	private string name;
	private GameObject gameObject;
	
	void Awake () {
		gameObject = GameObject.Find ("InputText");
		text = gameObject.GetComponent<Text> ();
		//Preventing the gameobject from being destroyed so that I can use the variable where the name is stored later in the leaderboards
		DontDestroyOnLoad (transform.gameObject);
	}

	void Update () {
		name = text.text;
	}

	public string nameGetter(){
		return name;
	}

	//Changing level when name is entered in the Menu
	public void changeLvl(){
		name = text.text;
		Application.LoadLevel ("Gamescene");
	}
}