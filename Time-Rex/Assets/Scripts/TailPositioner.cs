using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailPositioner : MonoBehaviour {

	public GameObject head;
	public GameObject leftHand;
	public GameObject rightHand;

	public float minDist = 1.25f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 headPos = head.transform.position;
		Vector3 leftPos = leftHand.transform.position;
		Vector3 rightPos = rightHand.transform.position;

		Vector3 newPos = new Vector3((headPos.x + leftPos.x + rightPos.x) / 3f, (headPos.y + leftPos.y + rightPos.y) / 3f, (headPos.z + leftPos.z + rightPos.z) / 3f);

		gameObject.transform.position = newPos;

		Vector3 handsAvg = new Vector3((leftPos.x + rightPos.x) / 2f, (leftPos.y + rightPos.y) / 2f, (leftPos.z + rightPos.z) / 2f);

		float yAngle = 0;

		yAngle = -Mathf.Rad2Deg*Mathf.Atan2(handsAvg.z - headPos.z, handsAvg.x - headPos.x);


		float zAngle = 0;
		if (handsAvg.y < minDist) {
			zAngle = -90;
		}



		//zAngle = 90 + Mathf.Rad2Deg*Mathf.Atan2(handsAvg.x - headPos.x, handsAvg.y - headPos.y);
		 
		/*
		if (handsAvg.y > headPos.y) {
			if (handsAvg.x > headPos.x) {
				zAngle = Mathf.Rad2Deg*Mathf.Atan2(handsAvg.y - headPos.y, handsAvg.x - headPos.x);
			}
			else {
				zAngle = Mathf.Rad2Deg*Mathf.Atan2(handsAvg.y - headPos.y, handsAvg.x - headPos.x);
			}
		}
		else {
			if (handsAvg.x > headPos.x) {
				zAngle = Mathf.Rad2Deg*Mathf.Atan2(handsAvg.y - headPos.y, handsAvg.x - headPos.x);
			}
			else {
				zAngle = Mathf.Rad2Deg*Mathf.Atan2(handsAvg.y - headPos.y, handsAvg.x - headPos.x);
			}
		}
		*/

		gameObject.transform.eulerAngles = new Vector3(0, yAngle, zAngle);
	}
}
