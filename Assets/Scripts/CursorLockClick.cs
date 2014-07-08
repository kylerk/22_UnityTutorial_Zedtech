using UnityEngine;
using System.Collections;

public class CursorLockClick : MonoBehaviour
{	

	// Use this for initialization
	void Start ()
	{
		Screen.lockCursor = true;
		guiTexture.enabled = true;
		
	}


	void OnMouseDown ()
	{
		Screen.lockCursor = true;
		guiTexture.enabled = false;
	}
	

	
	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKeyDown (KeyCode.Escape)) {
			Screen.lockCursor = false;
			guiTexture.enabled = true;
			Debug.Log ("switchLock");
		}


	
	}




}
