using UnityEngine;
using System.Collections;

public class Ammunition : MonoBehaviour
{

	void OnTriggerEnter (Collider collider)
	{
		if (collider.gameObject.name == "player") {
			GameVariables.keyDisplayTime += 5;
			GameVariables.ammunition += 2;
			Destroy (gameObject);

		}
	}
}
