﻿using UnityEngine;
using System.Collections;

public class ShootSpear : MonoBehaviour
{

	GameObject prefab;
	GameObject prefab2;
	// Use this for initialization
	void Start ()
	{
		prefab = Resources.Load ("Speer") as GameObject;
		prefab2 = Resources.Load ("tumbler") as GameObject;
		GameVariables.ammunition = 10;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0) && GameVariables.ammunition > 0) {
			GameVariables.ammunition--;
			GameObject projectile = Instantiate (prefab) as GameObject;
			projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
			projectile.transform.rotation = transform.rotation;
			projectile.transform.Rotate (90, 0, 0, Space.Self);
			Rigidbody rb = projectile.GetComponent<Rigidbody> ();
			rb.velocity = Camera.main.transform.forward * 40;


		}

		if (Input.GetMouseButtonDown (1)) {
			GameObject projectile = Instantiate (prefab2) as GameObject;
			projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
			projectile.transform.rotation = transform.rotation;
			projectile.transform.Rotate (90, 0, 0, Space.Self);
			Rigidbody rb = projectile.GetComponent<Rigidbody> ();
			rb.velocity = Camera.main.transform.forward * 40;
			
			
		}
	}
}
