using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isSolved = false;
    public Transform respawnPoint;  // The position where the ball will respawn

    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag)
        {
            isSolved = true;
            GetComponent<Light>().enabled = false;
            Destroy(collidedWith);
        }
    }

    public void ResetGoal()
    {
        isSolved = false;
        GetComponent<Light>().enabled = true;

        if (respawnPoint != null)
        {
            GameObject ball = GameObject.FindWithTag(gameObject.tag);
            if (ball != null)
            {
                ball.transform.position = respawnPoint.position;
                ball.SetActive(true);
            }
        }
    }
}

