using UnityEngine;
using System.Collections;

public class SimpleRecursion : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		if (transform.localScale.x > 0.01) {
			GameObject newCube = Instantiate (gameObject)as GameObject;
			newCube.transform.localScale = transform.localScale / 2;
			newCube.transform.position = new Vector3 (transform.position.x,
		                                       transform.position.y + renderer.bounds.size.y,
		                                       transform.position.z);

		}
	}

	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
