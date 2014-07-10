using UnityEngine;
using System.Collections;

public class SpriteTester : MonoBehaviour
{
	Sprite[] sprites;
	// Use this for initialization

	SpriteRenderer spriteRenderer;
	int frame = 0;
	float framerate = 1f / 8f;
	float time = 0.0f;
	void Start ()
	{	
		sprites = Resources.LoadAll<Sprite> ("SpriteWork/spriteGuy");
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		
		spriteRenderer.sprite = sprites [frame];
		time += Time.deltaTime;
		if (time > framerate) {
			frame++;
			time = 0;
		}
		
		if (frame >= sprites.Length)
			frame = 0;
	
	}
}
