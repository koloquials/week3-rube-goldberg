using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour {

	public Transform lookOverride;
	public Transform moveOverride;

	void OnTriggerEnter (Collider activator){
		Debug.Log (this.name + " got triggered by " + activator.name);
		CameraController camControl = Camera.main.GetComponent<CameraController> ();

		camControl.lookAtTarget = lookOverride;
		camControl.moveToTarget = moveOverride;
	}
}
