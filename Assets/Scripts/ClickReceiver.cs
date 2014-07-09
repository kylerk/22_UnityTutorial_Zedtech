using UnityEngine;
using System.Collections;

public class ClickReceiver : MonoBehaviour
{

	public int radioFrequency = 100;

	[System.Serializable]
	public class ClickAction
	{
		public Vector3 move = new Vector3 (0, 0, 0);
		public float moveDuration = 0;
		public bool addRigidBody = false;
		public bool removeBoxCollider = false;
		public bool enableRenderer = false;
		public bool disableRenderer = false;
		public bool destroy = false;
	}

	public ClickAction clickAction;
	private float moveTimer = 0;
	private Vector3 startPosition;
	private bool clicked = false;

	void Start ()
	{
		startPosition = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
	}

	void Update ()
	{

		if (moveTimer > 0) {
			moveTimer -= Time.deltaTime;

			float ratio = (clickAction.moveDuration - moveTimer) / clickAction.moveDuration;

			transform.position = startPosition + clickAction.move * ratio;

		}





	}




	public void activate ()
	{
		//Makes it only work once :-(
		if (clicked == true) 
			return;
		clicked = true;

		if (clickAction.move.sqrMagnitude > 0) {
			if (clickAction.moveDuration == 0) {
				transform.position = transform.position + clickAction.move;
			} else {
				moveTimer = clickAction.moveDuration;
			}
		}

		if (clickAction.addRigidBody)
			gameObject.AddComponent<Rigidbody> ();

		if (clickAction.removeBoxCollider) {
			BoxCollider bc = gameObject.GetComponent<BoxCollider> ();
			if (bc != null)
				bc.enabled = false;
		}

		if (clickAction.enableRenderer && gameObject.renderer != null)
			gameObject.renderer.enabled = true;

		if (clickAction.disableRenderer && gameObject.renderer != null)
			gameObject.renderer.enabled = false;

		if (clickAction.destroy)
			Destroy (gameObject);
		Debug.Log ("ithappened!");



	}

}
