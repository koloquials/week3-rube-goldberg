using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {

	void OnTriggerEnter (Collider activator){
		Debug.Log (activator.name + "activated this trigger!");

		Destroy (activator.gameObject);
	}
}
