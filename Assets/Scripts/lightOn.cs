using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightOn : MonoBehaviour {

    public GameObject light;

    private void OnTriggerEnter(Collider other)
    {
        light.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        //light.SetActive(false);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
