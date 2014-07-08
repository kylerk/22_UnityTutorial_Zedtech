using UnityEngine;
using System.Collections;

public class ClickTransmitter : MonoBehaviour
{


	public int radioFrequency = 100;
	private GameObject player;
	// Use this for initialization
	void Start ()
	{
	
		player = GameObject.Find ("player");
		if (player == null) {
			Debug.Log ("Couldn't find a gameobject player");
			enabled = false;
			return;
		}
	

		if (FindObjectOfType<ClickControl> () == null)
			player.AddComponent<ClickControl> ();

	}
}
