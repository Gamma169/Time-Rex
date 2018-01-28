using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabTurnOff : MonoBehaviour {

	VRTK.VRTK_InteractableObject vrtk;

	// Use this for initialization
	void Start () {
		vrtk = GetComponent<VRTK.VRTK_InteractableObject>();
	}
	
	// Update is called once per frame
	void Update () {
        if (vrtk.isGrabbable)
        {
            vrtk.touchHighlightColor = Color.yellow;
        }
        else {
            vrtk.touchHighlightColor = Color.clear;
        }
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "PlacerLocation") {
			vrtk.isGrabbable = false;
		}
	}

	void OnTriggerExit(Collider col) {
		if (col.gameObject.tag == "PlacerLocation") {
			vrtk.isGrabbable = true;
		}
	}
}
