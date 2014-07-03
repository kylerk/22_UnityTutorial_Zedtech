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
		player = GameObject.Find ("player");
		speed = 5;
		width = 4;
		timeCounter = 0;
	}


	Vector3 previous;
	float velocity;

	// Update is called once per frame
	void Update ()
	{
		timeCounter += Time.deltaTime * speed;

	


		


		velocity = ((player.transform.position - previous).magnitude) / Time.deltaTime;
		previous = transform.position;

		height = 5;

		Vector3 pos = transform.position;
		float z = Mathf.Sin (timeCounter + Mathf.Sqrt (pos.y * pos.y + pos.x * pos.x)) * height;
		float x = Mathf.Sin (timeCounter + pos.x);
		pos.z = z;
		transform.position = pos;

		renderer.material.color = new Vector4 (z, x, velocity, 1);
		Debug.Log (velocity);
	}
}
