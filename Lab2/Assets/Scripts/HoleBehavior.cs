using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleBehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            // Notify Game Manager to increase score
            FindObjectOfType<GameManager>().IncreaseScore();

            // Destroy the ball
            Object.Destroy(other.gameObject);
        }
    }

}
