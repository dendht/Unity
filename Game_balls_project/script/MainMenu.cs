using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void OnGUI ()
	{
		if (GUI.Button(new Rect(10,10,50,50),"Start"))
		{
			print ("Start Game");
			Application.LoadLevel("LoadLVL");
		}
		if (GUI.Button(new Rect(10,60,50,50),"Exit"))
		{
			print ("Exit");
			Application.Quit();
		}
	}
}
