using UnityEngine;
using System.Collections;

public class GameBrain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject prefab=Resources.Load ("Cube") as GameObject;
		for (int i=0;i<100;i++){
			GameObject go=Instantiate(prefab) as GameObject;
			go.transform.position=new Vector3(0,i*5,0);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
