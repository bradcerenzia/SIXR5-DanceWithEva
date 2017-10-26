using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowApple : MonoBehaviour {

    public GameObject fruit;
    public GameObject CanvasObject;

    private void OnTriggerEnter(Collider other)
    {
        // make apple visible
        fruit.SetActive(true);
  
        // enable scroll of credits
        CanvasObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        fruit.SetActive(false);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
