using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressKeyToSwapSky : MonoBehaviour
{

    public Renderer thisRenderer;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {   // Space pressed.  Toggle mesh renderer.
            thisRenderer.enabled = !thisRenderer.enabled;
        }
    }
}
