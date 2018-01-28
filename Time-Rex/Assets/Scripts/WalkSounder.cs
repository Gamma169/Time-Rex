using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkSounder : MonoBehaviour {

	public VRTK.VRTK_MoveInPlace mover;

	public AudioSource[] steps;

	bool playing;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (mover.GetSpeed() > 1 && !playing) {
			playing = true;
			StartCoroutine("PlaySound");
		}
	}

	IEnumerator PlaySound() {
		int sound = (int)Mathf.Floor(Random.Range(0, steps.Length - 1 + .99f));
		steps[sound].Play();
        yield return new WaitForSeconds(1 / mover.GetSpeed());
		playing = false;
	}
}
