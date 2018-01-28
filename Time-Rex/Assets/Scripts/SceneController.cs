using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	public HoldingController[] hcs;

	public bool win;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R)) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}


		for (int i = 0; i < hcs.Length && !win; i++) {
			win = hcs[i].correctObject;
			if (!win)
				break;
		}

		Debug.Log(win);
	}
}
