using UnityEngine;
using System.Collections;

public class enemy1 : MonoBehaviour {
	// Update is called once per frame
	void Update () {
	if (this.transform.position.x >=4.4f)
		{
			this.transform.position = new Vector3(Random.Range(-3.533806f,3.324787f), Random.Range(3.519296f,-1.539012f));
		}
		else
		{
			transform.Translate(new Vector3(0.04f,0.0f,0.0f));
		}
	}
}
