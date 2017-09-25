using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMovieCopyPositionScript : MonoBehaviour
{
    public Camera cameraToFollow;

    // Use this for initialization
    void Start()
    {
        // make Movie Texture begin playing
        //((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
        Renderer renderer = GetComponent<Renderer>();
        Material material = renderer.material;
        Texture texture = material.mainTexture;
        ((MovieTexture)texture).Play();
    }

    // Update is called once per frame
    void Update()
    {
        // Copy position only (not orientation) from pseudoParent.
        // This makes SkySphere follow camera without panning and tilting Sky with camera.
        transform.position = cameraToFollow.transform.position;
    }
}
