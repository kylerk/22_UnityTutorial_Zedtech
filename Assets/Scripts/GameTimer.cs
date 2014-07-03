using UnityEngine;
using System.Collections;

public class GameTimer : MonoBehaviour
{
	float timeCounter = 0 ;
	// Use this for initialization
	void Start ()
	{
		
	}

	// Update is called once per frame
	void Update ()
	{
		timeCounter += Time.deltaTime;
				
		if (timeCounter > 1) {
			timeCounter = 0;					
			Debug.Log ("Every second!");


		}
	}
}