using UnityEngine;
using System.Collections;

public class BrownianMotion : MonoBehaviour
{

	float getRandomValue ()
	{
		return Random.Range (-10, 10);
	}


	// Update is called once per frame
	void Update ()
	{
	
		if (Input.GetKeyDown (KeyCode.H)) {
			Rigidbody rb = GetComponent<Rigidbody> ();
			rb.velocity = new Vector3 (getRandomValue (), getRandomValue (), getRandomValue ());


		}

	}
}
