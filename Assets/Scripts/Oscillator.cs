using UnityEngine;
using System.Collections;

public class Oscillator : MonoBehaviour
{




	// Use this for initialization
	void Start ()
	{


		GameObject prefab = Resources.Load ("Stuff/SphereLight") as GameObject;
		for (int ix= -10; ix<10; ix++) {
			for (int iy= -10; iy<10; iy++) {
				GameObject go = Instantiate (prefab) as GameObject;
				go.transform.position = new Vector3 (ix, iy, 0);
			}
		}

	}
	
	// Update is called once per frame
	void Update ()
	{



	}
}
