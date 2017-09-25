using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireOn : MonoBehaviour {

    public GameObject fireParticleSystem;

    private void OnTriggerEnter(Collider other)
    {
        fireParticleSystem.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        fireParticleSystem.SetActive(false);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
