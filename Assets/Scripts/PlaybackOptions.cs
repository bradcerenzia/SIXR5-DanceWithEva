using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlaybackOptions : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
            Application.LoadLevel(1);
    }
}

