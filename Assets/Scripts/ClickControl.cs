﻿using UnityEngine;
using System.Collections;

public class ClickControl : MonoBehaviour
{

	private float range = 10;

	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			Vector3 pos = Camera.main.transform.position;
			RaycastHit rayCastHit = new RaycastHit ();

			if (Physics.Linecast (pos, pos + Camera.main.transform.forward * range, out rayCastHit, 1)) {
				GameObject hitObject = rayCastHit.transform.gameObject;

				ClickTransmitter ct = hitObject.GetComponent<ClickTransmitter> ();

				if (ct != null) {
					foreach (ClickReceiver cr in FindObjectsOfType<ClickReceiver>())
						if (cr.radioFrequency == ct.radioFrequency)
							cr.activate ();
				}
			}
		}
	}
}