using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallActivator : MonoBehaviour {
	public Text textBox;
	public GameObject door;
	bool spaceHint = true;

	void Start () {
		textBox.text = "[press space to begin]"; 
	}

	void Update () {
		if (spaceHint == false) {
			textBox.text = "";
			spaceHint = true;
		}
		if (Input.GetKeyDown(KeyCode.Space)) {
			spaceHint = false;
			door.SetActive(false);
		}
	}
}
