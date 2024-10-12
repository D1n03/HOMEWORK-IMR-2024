using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleBehavior : MonoBehaviour
{
    public static int scoreCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            if (other.CompareTag("Ball"))
            {
                print("Score before: " + scoreCount);
                print("Collided with a ball!");
                scoreCount++;
                Object.Destroy(other);
                print("Score now: " + scoreCount);
            }
        }
    }

    public int GetScoreCount()
    {
        return scoreCount;
    }
}
