using UnityEngine;
using System.Collections;

public class LoadLVL : MonoBehaviour {

	void OnGUI ()
	{
		if (GUI.Button(new Rect(10,10,100,50),"Low"))
		{
			print ("Low");
			Application.LoadLevel("Lvl1");
		}
		if (GUI.Button(new Rect(10,60,100,50),"Medium"))
		{
			print ("Medium");
			Application.LoadLevel("Lvl2");
		}
		if (GUI.Button(new Rect(10,110,100,50),"Hard"))
		{
			print ("Hard");
			Application.LoadLevel("Lvl3");
		}
}
}