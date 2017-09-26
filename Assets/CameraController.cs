using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform lookAtTarget;
	public Transform moveToTarget;
	
	void Update () {
		if (lookAtTarget != null) {
			transform.LookAt (lookAtTarget.position);
		}

		if (moveToTarget != null) {
			Vector3 moveDirection = moveToTarget.position - transform.position;
			if (moveDirection.magnitude > 1f) {
				moveDirection = moveDirection.normalized;
			}
			transform.position += moveDirection * Time.deltaTime * 10f;
		}


	}
}
