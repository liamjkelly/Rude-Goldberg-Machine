using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarterScript : MonoBehaviour {

	public Text myText;
	public AudioSource mySource;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			myText.text = "";
			//GetComponent<BoxCollider>().gameObject.SetActive(true);
			mySource.Play ();
		}
	}
}
