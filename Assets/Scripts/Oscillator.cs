using UnityEngine;
using System.Collections;

public class Oscillator : MonoBehaviour
{




	// Use this for initialization
	void Start ()
	{


		GameObject prefab = Resources.Load ("Stuff/SphereLight") as GameObject;
		for (int ix= -20; ix<20; ix++) {
			for (int iy= -20; iy<20; iy++) {
				GameObject go = Instantiate (prefab) as GameObject;
				go.transform.position = new Vector3 (ix / 2, iy / 2, 0);
			}
		}

	}
	
	// Update is called once per frame
	void Update ()
	{



	}
}
