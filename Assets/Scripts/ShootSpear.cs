using UnityEngine;
using System.Collections;

public class ShootSpear : MonoBehaviour
{

	GameObject prefab;

	// Use this for initialization
	void Start ()
	{
		prefab = Resources.Load ("Speer") as GameObject;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			GameObject projectile = Instantiate (prefab) as GameObject;
			projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
			projectile.transform.rotation = transform.rotation;
			projectile.transform.Rotate (90, 0, 0, Space.Self);
			Rigidbody rb = projectile.GetComponent<Rigidbody> ();
			rb.velocity = Camera.main.transform.forward * 40;


		}
	}
}
