using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    private int bounceCount = 0;

    // Called when the sphere collides with the cube
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the sphere (assuming the sphere has the tag "Player")
        if (collision.gameObject.CompareTag("Player"))
        {
            // Increase the bounce count
            bounceCount++;

            // Print the bounce count to the console
            print("Bounce count: " + bounceCount);
        }
    }
}