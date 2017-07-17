using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnd : MonoBehaviour {


	
	// Update is called once per frame
	void OnTriggerEnter (object other) {
		GetComponent<ParticleSystem>().gameObject.SetActive (true);
	}
}
