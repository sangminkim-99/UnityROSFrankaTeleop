using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GripperActionMananger : MonoBehaviour
{
    public InputActionProperty pinchAction;
    public float gripperWidth;

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAction.action.ReadValue<float>();
        gripperWidth = trigger2gripper(triggerValue);
    }

    float trigger2gripper(float triggerValue) 
    {
        // gripper : 0.005 to 0.08
        // trigger : 1.0 to 0.0 (both closed -> open)
        var gw = (-triggerValue + 1.0f) * 0.075f + 0.005f;
        return gw;
    }
}
