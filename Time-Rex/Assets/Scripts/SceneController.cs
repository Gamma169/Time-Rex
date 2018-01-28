using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	public static float timeLeft = 200f;

	public HoldingController[] hcs;

	public bool win;
	public bool lose;

	public bool playing;

	public AudioSource halfdone;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R)) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}

		int correct = 0;
		for (int i = 0; i < hcs.Length && !win ; i++) {
			if (hcs[i].correctObject) {
				correct++;
			}
		}

		if (win || correct >= hcs.Length) {
			win = true;
		}
		else if (correct >= 3) {
			playing = true;

		}

		else {
			win = false;
			playing = false;
		}

		halfdone.enabled = playing;

		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
			win = false;
			if (!lose) {
				lose = true;
			}
		}

		//Debug.Log(win);
	}
}
