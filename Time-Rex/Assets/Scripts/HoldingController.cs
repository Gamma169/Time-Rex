using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldingController : MonoBehaviour {

	public bool objectInSpot;

	public bool correctObject;

	public string correctName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (correctName == "ArtifactB" && correctObject) {
            //Debug.Log("Test");
        }
	}

	void OnTriggerStay(Collider col) {
		if (col.gameObject.tag == "Obj") {
			objectInSpot = true;
			if (col.gameObject.name == correctName)
				correctObject = true;
		}
	}

	void OnTriggerExit(Collider col) {
		if (col.gameObject.tag == "Obj") {
			objectInSpot = false;
			correctObject = false;
		}
	}
}
