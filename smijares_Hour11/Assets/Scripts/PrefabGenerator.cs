using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    private int maxClones = 10;
    private float spacing = 3f;

    void Start()
    {
        for (int i = 0; i < maxClones; i++)
        {
            Vector3 spawnPosition = new Vector3(transform.position.x + (i + 1) * spacing, 4.3f, transform.position.z);
            Quaternion spawnRotation = Quaternion.Euler(0, 270, 0);
            Instantiate(prefab, spawnPosition, spawnRotation);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}


