using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdScriptTIY : MonoBehaviour
{
    public int runSpeed;
    // Start is called before the first frame update
    void Start()
    {
        float health = 1004;
        float poisonDamage = 125.5f;
        Debug.Log(health);
        health -= poisonDamage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
