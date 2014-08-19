using UnityEngine;
using System.Collections;

public class FramesPerSecond : MonoBehaviour
{
	Rect fpsRect;
	Rect fpsRect1;
	Rect fpsRect2;
	Rect fpsRect3;
	GUIStyle style;

	float fps;
	float fps1;
	int fps2;
	float varianceFPS;
	float displayVarianceFPS;
	float lastDeltaTime;

		
	int deltaframes;
	float timeSinceLastFPS;
	void Start ()
	{
		fpsRect = new Rect (100, 100, 400, 400);
		fpsRect1 = new Rect (100, 150, 400, 400);
		fpsRect2 = new Rect (100, 200, 400, 400);
		fpsRect3 = new Rect (100, 250, 400, 400);
		style = new GUIStyle ();
		style.fontSize = 30;

		StartCoroutine (RecalculateFPS ());
	}

	private IEnumerator RecalculateFPS ()
	{
		while (true) {

			fps = deltaframes / timeSinceLastFPS;
			fps1 = 1 / Time.deltaTime;
			fps2 = deltaframes;
			displayVarianceFPS = varianceFPS * 1000;
			timeSinceLastFPS = 0;
			deltaframes = 0;
			varianceFPS = 0;
			yield return new WaitForSeconds (1);
		}

	}
	// Update is called once per frame
	void Update ()
	{
		deltaframes += 1;
		timeSinceLastFPS += Time.deltaTime;
		varianceFPS += Mathf.Abs (Time.deltaTime - lastDeltaTime);


		lastDeltaTime = Time.deltaTime;
	}

	void OnGUI ()
	{
		//float fps = 1 / Time.deltaTime;
		GUI.Label (fpsRect, "FPS: " + string.Format ("{0:0.0}", fps), style);
		GUI.Label (fpsRect1, "FPS1: " + string.Format ("{0:0.0}", fps1), style);
		GUI.Label (fpsRect2, "FPS2: " + fps2, style);
		GUI.Label (fpsRect3, "Variance: " + string.Format ("{0:0.0}", displayVarianceFPS), style);
	}

}
