using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddlebehaviour : MonoBehaviour
{
    public KeyCode input;
    public float pressed;
    public float released;

    private HingeJoint hinge;
    private void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    private void Update()
    {
        getInput();
    }

    private void getInput()
    {
        JointSpring jointSpring = hinge.spring;

        if (Input.GetKey(input))
        {
            jointSpring.targetPosition = pressed;
        }
        else
        {
            jointSpring.targetPosition = released;
        }

        hinge.spring = jointSpring;
    }
}
