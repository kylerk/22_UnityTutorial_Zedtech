using UnityEngine;
using System.Collections;

public class FallDetect : MonoBehaviour
{


	void Start ()
	{
	
		GameVariables.checkpoint = new Vector3 (0, 7, 0);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (transform.position.y < -10) {
			transform.position = GameVariables.checkpoint;

		
		}
	}
}
