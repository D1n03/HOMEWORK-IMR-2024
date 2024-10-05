using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusBehavior : MonoBehaviour
{
    public Transform cactusATransform;
    public Transform cactusBTransform;

    public Animator cactusAAnimator;
    public Animator cactusBAnimator;

    public float collisionDistance;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float currentDistance = Vector3.Distance(cactusATransform.position, cactusBTransform.position);

        print(currentDistance);

        bool isClose = currentDistance < collisionDistance;
        if (isClose)
        {
            print("Collision!");
        }
        SetIsCloseToOther(isClose);
    }
    void SetIsCloseToOther(bool isClose)
    {
        cactusAAnimator.SetBool("isCloseToOther", isClose);
        cactusBAnimator.SetBool("isCloseToOther", isClose);
    }
}
