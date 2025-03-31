using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    private Light pointLight;

    void Start()
    {
        pointLight = GetComponent<Light>(); // Get the Light component attached to the GameObject
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) // Check if the 'L' key is pressed
        {
            pointLight.enabled = !pointLight.enabled; // Toggle the light on/off
        }
    }
}
