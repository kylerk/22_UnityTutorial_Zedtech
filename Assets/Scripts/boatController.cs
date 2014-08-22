using UnityEngine;
using System.Collections;

public class boatController : MonoBehaviour
{
	CharacterController cc;
	CharacterMotor cm;
	GameObject player;
	Transform defaultPlayerTransform;
	bool isDriving = false;
	// Use this for initialization
	void Start ()
	{
		cc = GameObject.FindObjectOfType<CharacterController> ();
		cm = GameObject.FindObjectOfType<CharacterMotor> ();
		player = cm.gameObject;
		defaultPlayerTransform = player.transform.parent;
		Debug.Log (defaultPlayerTransform);

	}

	void SetDriving (bool isDriving)
	{
		this.isDriving = isDriving;

		cm.enabled = !isDriving;
		cc.enabled = !isDriving;

		if (isDriving)
			player.transform.parent = gameObject.transform;
		else
			player.transform.parent = defaultPlayerTransform;
		Debug.Log (player.transform.parent);	
	}

	bool IsPlayerCloseToBoat ()
	{
		return Vector3.Distance (gameObject.transform.position, player.transform.position) < 1;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.E)) {
			SetDriving (!isDriving);

		}

		if (isDriving) {
			float forwardThrust = 0;
			if (Input.GetKey (KeyCode.W))
				forwardThrust = 7;
			if (Input.GetKey (KeyCode.S))
				forwardThrust = -7;

			rigidbody.AddForce (gameObject.transform.forward * forwardThrust);

			float turnThrust = 0;
			if (Input.GetKey (KeyCode.A))
				turnThrust = -4;
			if (Input.GetKey (KeyCode.D))
				turnThrust = 4;

			rigidbody.AddRelativeTorque (Vector3.up * turnThrust);

		}

		rigidbody.velocity = Vector3.ClampMagnitude (rigidbody.velocity, 5);

	}
}
