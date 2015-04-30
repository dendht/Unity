using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {

	void OnGUI()
	{
		GUI.Label(new Rect(200,100,100,100),"You Win!!!!");
		if (GUI.Button(new Rect(10,100,100,50),"MainMenu"))
		{
			Application.LoadLevel("Main Menu");
		}
	}
}
