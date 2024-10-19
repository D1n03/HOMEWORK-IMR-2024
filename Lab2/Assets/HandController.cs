using UnityEngine;
using UnityEngine.InputSystem;

public class HandController : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;

    public Animator handAnimator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);

        float gripValue = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);

        //Debug.Log("Trigger: " + triggerValue);
        //Debug.Log("Grip: " + gripValue);
    }
    //public InputActionReference gripInput;
    //public InputActionReference triggerInput;

    //private Animator animator;

    //private void Awake()
    //{
    //    animator = GetComponent<Animator>();
    //}
    //void Update()
    //{
    //    if (!animator) return;
    //    float grip = gripInput.action.ReadValue<float>();
    //    float trigger = triggerInput.action.ReadValue<float>();

    //    animator.SetFloat("Grip", grip);
    //    animator.SetFloat("Trigger", trigger);
    //}
}
