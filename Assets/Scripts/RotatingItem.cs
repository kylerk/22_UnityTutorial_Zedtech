using UnityEngine;
using System.Collections;

public class RotatingItem : MonoBehaviour
{
	void Start ()
	{

		transform.Rotate (new Vector3 (0, Random.Range (0, 360), 0));
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Rotate (new Vector3 (0, 60 * Time.deltaTime, 0));
	}
}
