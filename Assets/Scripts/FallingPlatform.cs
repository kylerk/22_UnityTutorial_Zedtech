using UnityEngine;
using System.Collections;

public class FallingPlatform : MonoBehaviour
{
	bool isFalling = false;
	bool direction = true;
	float speed = 0;
	void OnTriggerEnter (Collider collider)
	{
		if (collider.gameObject.name == "player") {
			isFalling = true;
			Debug.Log ("falling" + isFalling);
		}
	}

	void Update ()
	{
		if (isFalling) {

			if (transform.position.y > 12)
				direction = false;
			if (transform.position.y < 10)
				direction = true;

			if (direction) {
				Debug.Log ("up");
				speed += Time.deltaTime / 8;
			}

			if (!direction) {
				Debug.Log ("down");
				speed -= Time.deltaTime / 8;
			}

			transform.position = new Vector3 (transform.position.x, transform.position.y + speed, transform.position.z);

		}

		//Debug.Log (speed + " " + direction);
	}

}
