using UnityEngine;
using System.Collections;


public class CameraController : MonoBehaviour {
	private float score = 5;
	private float plusScore=2;
	private Vector3 newPosition;
	public float RespawnTime = 2.0f;
	public float[] scoreArray;
	public float DataTime = 2.00f;
	private float minusscore=0.04f;
	
	void Start () {
	print (Screen.currentResolution.width);
	}
	//-7.62087f,7.261227f    3.08924f,-1.273261f
	// Update is called once per frame
	void Update () {
	if (Input.GetMouseButtonDown(0))
		{	RaycastHit hit;
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			
			if (Physics.Raycast(ray,out hit, 100))
			{
			newPosition = new Vector3(Random.Range(-3.533806f,3.324787f), Random.Range(3.519296f,-1.539012f));
			hit.transform.position= newPosition;
			
			print("click");
			score += plusScore;
				//print (gameObject.transform.position.x);
			if (hit.transform.tag == "enemy") 
			{
				Destroy(hit.transform.gameObject);
					
				} 
				if (gameObject.transform.position.x >= 3.324787f)
					{
				Destroy(hit.transform.gameObject);
					
				} 
			}
			
		}
		else
			{
				score -= minusscore;
			}
	}
	void OnGUI ()
	{
		GUI.Label(new Rect(10,10,50,50),"Score " + System.Convert.ToInt32(score));
		GUI.Label(new Rect(100,10,50,50),"Time " + DataTime);
		if (score ==50)
		{
			Application.LoadLevel("Win");
		}
		else if(System.Convert.ToInt32(score)==0)
		{
			Application.LoadLevel("Lose");
		}
	}
}