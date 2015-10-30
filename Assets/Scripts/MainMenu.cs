using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour{

	//Made by Danny Kruiswijk

	[SerializeField] private GUISkin gameSkin;
	private string gameName = "3D Pinball";
	private GameObject inputTextObject;

	void Start(){
		inputTextObject = GameObject.Find ("InputField");
	}

	//The '3D Pinball' text
	void OnGUI()
	{
		GUI.skin = gameSkin;
		GUI.Label(new Rect(30, 30, 300, 25), gameName, "Menu Title");
		QualitySettings.SetQualityLevel(100, true);
	}

	//Making the name field appear once the Start button has been pressed
	public void changeZ(){
		inputTextObject.transform.position = new Vector3 (transform.position.x,transform.position.y,transform.position.z + 100f);
	}
}
