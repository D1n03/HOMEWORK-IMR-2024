using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfBallBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().maxAngularVelocity = 40;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
