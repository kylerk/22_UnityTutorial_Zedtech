using UnityEngine;
using System.Collections;

public class FaceCtrl : MonoBehaviour
{
	Sprite[] faceSprite;
	SpriteRenderer spriteRenderer;

	public int rangeMin;
	public int rangeMax;


	// Use this for initialization
	void Start ()
	{
		faceSprite = Resources.LoadAll<Sprite> ("FaceRig/faceRig");
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}

	// Update is called once per frame
	void Update ()
	{
		if (gameObject.name == "Mouth") {

			float target = (Input.GetAxis ("Vertical") + 1) / 2;
			int frame = (int)Mathf.Lerp (rangeMin, rangeMax, target);

			spriteRenderer.sprite = faceSprite [frame];
		}

		if (gameObject.name == "REye") {
			
			float target = (Input.GetAxis ("Fire1"));
			int frame = (int)Mathf.Lerp (rangeMin, rangeMax, target);
			
			spriteRenderer.sprite = faceSprite [frame];
		}
		if (gameObject.name == "LEye") {
			
			float target = (Input.GetAxis ("Fire2"));
			int frame = (int)Mathf.Lerp (rangeMin, rangeMax, target);
			
			spriteRenderer.sprite = faceSprite [frame];
		}
		if (gameObject.name == "Nose") {
			
			float target = (Input.GetAxis ("Fire3") + 1) / 2;
			int frame = (int)Mathf.Lerp (rangeMin, rangeMax, target);
			
			spriteRenderer.sprite = faceSprite [frame];
		}


		//Debug.Log (frame + "target:" + target);
	}
}
