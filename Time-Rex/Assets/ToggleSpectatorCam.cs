using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSpectatorCam : MonoBehaviour {

    public GameObject SC;

    public GameObject ArtifactsBonus;

    public bool boolSC;

    public bool boolArtifacts;



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            SpawnArtifacts();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            ToggleSC();
        }
    }

    void SpawnArtifacts ()
    {
            boolArtifacts = !boolArtifacts;
            ArtifactsBonus.SetActive(boolArtifacts);
    }


    void ToggleSC ()
    {
            boolSC = !boolSC;
            SC.SetActive(boolSC);
    }
}
