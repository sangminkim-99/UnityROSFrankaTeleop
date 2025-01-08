using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class ClickManager : MonoBehaviour
{
    public InputActionProperty pinchAction;
    public UnityEvent onRelease;

    public bool hasPressed = false;

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAction.action.ReadValue<float>();

        var isPressed = triggerValue >= 0.99;
        if (hasPressed && !isPressed) 
        {
            // on Release
            onRelease.Invoke();
        }

        hasPressed = isPressed;
    }
}