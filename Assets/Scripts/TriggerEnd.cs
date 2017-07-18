using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerEnd : MonoBehaviour {

	public AudioSource mySource;
	public Text myText;
	
	// Update is called once per frame
	void OnTriggerEnter (object other) {
		myText.text = "Success is a societal expectation not the norm";
		mySource.Stop ();
	}
}
