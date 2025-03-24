using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirthdayMonth : MonoBehaviour
{
    void Start()
    {
        for (int day = 1; day <= 30; day++) // Loop from 1 to 30 (November)
        {
            if (day == 14) // Check if it's the 14th
            {
                Debug.Log("It's my birthday!");
            }
            else
            {
                Debug.Log(day);
            }
        }
    }
}