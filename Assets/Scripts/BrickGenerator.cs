using UnityEngine;
using System.Collections;

public class BrickGenerator : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		GameObject prefab = Resources.Load ("brick") as GameObject;

		for (int i=0; i<8; i++) {
			for (int h=0; h<8; h++) {
				GameObject brick = Instantiate (prefab) as GameObject;

				brick.transform.position = new Vector3 (transform.position.x + i * 2 + h % 2,
				                                    	 transform.position.y + h,
				                                     	transform.position.z);
			}
		}
	}
	

}
