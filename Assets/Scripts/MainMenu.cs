using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour 
{
	[SerializeField]
	private GUISkin gameSkin;
	private string gameName = "3D Pinball";
	[SerializeField]
	private Camera gameCamera;
	
	void OnGUI()
	{
		GUI.skin = gameSkin;
		GUI.Label(new Rect(30, 30, 300, 25), gameName, "Menu Title");
		QualitySettings.SetQualityLevel(100, true);
	}
	public void nextScene(string whichScene){
		Application.LoadLevel (whichScene);
	}
}
