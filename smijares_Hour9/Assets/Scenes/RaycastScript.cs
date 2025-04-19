using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Get the mouse movement input
        float dirX = Input.GetAxis("Mouse X");
        float dirY = Input.GetAxis("Mouse Y");

        // Rotate the object based on mouse movement
        transform.Rotate(dirY, -dirX, 0);

        // Call the method to check for raycast hits
        CheckForRaycastHit();
    }

    // Method to check for raycast hits and destroy the hit object
    void CheckForRaycastHit()
    {
        RaycastHit hit;

        // Cast a ray from the object's position in the forward direction
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            print(hit.collider.gameObject.name + " destroyed!");
            Destroy(hit.collider.gameObject); // Destroy the object the ray hits
        }
    }
}
