using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenNumbers : MonoBehaviour
{
    void Start()
    {
        for (int i = 22; i <= 100; i++) // Increment by 1
        {
            if (i % 2 == 0) // Check if the number is even
            {
                Debug.Log(i);
            }
        }
    }
}