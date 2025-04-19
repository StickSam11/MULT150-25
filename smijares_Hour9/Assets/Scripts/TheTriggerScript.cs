using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheTriggerScript : MonoBehaviour
{
    // Called when another collider enters the trigger
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Assuming the sphere has the "Player" tag
        {
            print(other.gameObject.name + " has entered " + gameObject.name);
        }
    }

    // Called every frame while another collider is inside the trigger
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player")) // Assuming the sphere has the "Player" tag
        {
            print(other.gameObject.name + " is still in " + gameObject.name);
        }
    }

    // Called when another collider exits the trigger
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Assuming the sphere has the "Player" tag
        {
            print(other.gameObject.name + " has left " + gameObject.name);
        }
    }
}
