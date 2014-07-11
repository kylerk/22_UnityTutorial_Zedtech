using UnityEngine;
using System.Collections;

public class TeleportPad : MonoBehaviour
{
	public int code;
	float disableTime = 0f;

	void Update ()
	{
		disableTime -= Time.deltaTime;

	}

	void OnTriggerEnter (Collider collider)
	{
		if (collider.gameObject.name == "player" && disableTime <= 0) {


			foreach (TeleportPad tp in FindObjectsOfType<TeleportPad>()) {

				if (tp.code == code && tp != this) {
					tp.disableTime = 2;

					Vector3 position = tp.gameObject.transform.position;
					position.y += 8;
					collider.gameObject.transform.position = position;
				}
			}
		}


	}
}
