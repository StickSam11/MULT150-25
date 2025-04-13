using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) // Changed from "Jump" to 'Z' key
        {
            if (audioSource.isPlaying)
                audioSource.Stop();
            else
                audioSource.Play();
        }
    }
}
