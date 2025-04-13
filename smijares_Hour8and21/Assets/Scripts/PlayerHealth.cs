using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Declare and assign the healthpoints variable
    int healthpoints = 3992;

    void Start()
    {
        // Use potions 4 times and update healthpoints each time
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);

        // Log the final healthpoints value
        Debug.Log(healthpoints);
    }

    void Update()
    {
        // This is called once per frame
    }

    // Define the UsePotion method
    int UsePotion(int health)
    {
        health += 400;
        return health;
    }
}