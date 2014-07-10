using UnityEngine;
using System.Collections;

public class AmmoDisplay : MonoBehaviour
{

	Rect rect;
	Texture texture;
	float textureSize = 0.0002f;
	int screenWidth;
	int screenHeight;
	Rect newrect;
	// Use this for initialization
	void Start ()
	{   

		texture = Resources.Load ("Textures/Moose") as Texture;
		screenWidth = Screen.width;
		screenHeight = Screen.height;	


		rect = TextureRect (texture.width, texture.height, textureSize);



	}

	void Update ()
	{

		if (screenWidth != Screen.width || screenHeight != Screen.height)
			rect = TextureRect (texture.width, texture.height, textureSize);
	}
	
	// Update is called once per frame
	void OnGUI ()
	{
		newrect = rect;
		for (int i = 0; i<GameVariables.ammunition; i++) {
			//GUI.DrawTexture (rect, texture);	

			newrect.x += rect.width / 2;
			GUI.DrawTexture (newrect, texture);
			//Debug.Log (rect);

		}
	}

	Rect TextureRect (int textureWidth, int textureHeight, float texSize)
	{
		return new Rect (Screen.width * 0.1f,
		                 Screen.height - Screen.width * 0.3f * textureHeight * texSize,
		                 Screen.width * 0.3f * textureWidth * texSize,
			         Screen.width * 0.3f * textureHeight * texSize);


	}

}
