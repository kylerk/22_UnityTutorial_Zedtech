using UnityEngine;
using System.Collections;

public class ExplodingProjectile : MonoBehaviour
{


	void Start ()
	{

	}

	void OnCollisionEnter (Collision collision)
	{
		Destroy (gameObject);
		GameObject prefab = Resources.Load ("Fireworks") as GameObject;
		GameObject fireworks = Instantiate (prefab) as GameObject;
		fireworks.transform.position = transform.position;
		Destroy (gameObject);

		Destroy (fireworks, 5);

	}


}
