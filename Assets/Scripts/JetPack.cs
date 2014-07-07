using UnityEngine;
using System.Collections;

public class JetPack : MonoBehaviour
{

	CharacterMotor cm;
	CharacterController cc;

	// Use this for initialization
	void Start ()
	{
		cm = (CharacterMotor)GetComponent<CharacterMotor> ();
		cc = (CharacterController)GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
		if (Input.GetKey (KeyCode.LeftShift)) {
			Vector3 velocity = new Vector3 (cc.velocity.x, 10, cc.velocity.z);
			cm.SetVelocity (velocity);
		}

	}
}
