using UnityEngine;
using System.Collections;

public class Lose : MonoBehaviour {

	void OnGUI()
	{
		GUI.Label(new Rect(200,100,100,100),"You Loser!!!!");
		
		if (GUI.Button(new Rect(10,100,100,50),"MainMenu"))
		{
			Application.LoadLevel("Main Menu");
		}
	}
}
