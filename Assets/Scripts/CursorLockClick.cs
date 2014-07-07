using UnityEngine;
using System.Collections;

public class CursorLockClick : MonoBehaviour
{	




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
		}

		


	}




}
