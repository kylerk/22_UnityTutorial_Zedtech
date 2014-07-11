using UnityEngine;
using System.Collections;

public class KeyItem : MonoBehaviour
{


	void OnTriggerEnter (Collider collider)
	{

		if (collider.gameObject.name == "player") {
			GameVariables.keyCount += 1;
			Destroy (gameObject);
		}
	}
}
