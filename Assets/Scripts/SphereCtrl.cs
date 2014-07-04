using UnityEngine;
using System.Collections;

public class SphereCtrl : MonoBehaviour
{
	float timeCounter;
	float speed;
	float width;
	float height;
	public GameObject player;

	// Use this for initialization
	void Start ()
	{
		speed = 5;
		width = 4;
		height = 5;
		timeCounter = 0;
	}


	Vector3 previous;
	float velocity;

	// Update is called once per frame
	void Update ()
	{
		timeCounter += Time.deltaTime * speed;
		Vector3 pos = transform.position;
		float z = Mathf.Sin (timeCounter / 10 + Mathf.Sqrt (pos.y * pos.y + pos.x * pos.x)) * height;
		float x = Mathf.Sin (timeCounter / 4 + pos.x);
		pos.z = z;
		transform.position = pos;

		//renderer.material.color = new Vector4 (z, x, z, 1);
	
	}
}
