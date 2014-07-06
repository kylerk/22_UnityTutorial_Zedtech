using UnityEngine;
using System.Collections;

public class HideCursor : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
				Screen.showCursor = false;
				Screen.lockCursor = true;
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
				if (Input.GetKeyDown (KeyCode.Escape)) {
						Screen.showCursor = !Screen.showCursor;
						Screen.lockCursor = !Screen.lockCursor;
				}
		}
}
