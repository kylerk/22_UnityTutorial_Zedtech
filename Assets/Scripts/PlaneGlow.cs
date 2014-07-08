using UnityEngine;
using System.Collections;

public class PlaneGlow : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		GameObject prefab = Resources.Load ("markerlight") as GameObject;
		int stepSize = 5;
		for (int x=0; x<renderer.bounds.size.x; x+=stepSize) {
			for (int z=0; z<renderer.bounds.size.z; z+=stepSize) {
				GameObject go = Instantiate (prefab) as GameObject;
				go.transform.position = new Vector3 (x - renderer.bounds.size.x / 2, 0, z - renderer.bounds.size.z / 2) + transform.position;
			}
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
