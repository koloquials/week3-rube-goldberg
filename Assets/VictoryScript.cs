using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryScript : MonoBehaviour {
	public GameObject plug;
	public Text textBox;
	bool victory = false;
	void OnTriggerEnter (Collider activator){
		victory = true;
		plug.SetActive(false);
	}

	void Update(){
		if (victory == true) {
			textBox.text = "[you win!!! a couple of minutes of life you aren't getting back.]"; 
		}
	}
}
