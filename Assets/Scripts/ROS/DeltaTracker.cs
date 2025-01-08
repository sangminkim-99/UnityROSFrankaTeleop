using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTracker : MonoBehaviour
{
    public Transform referenceTf;
    public Transform targetDeltaTf;
    public InputHandler inputHandler;

    public Vector3 prevTrans;
    public Quaternion prevQuat;

    void Start()
    {
        prevTrans = referenceTf.position;
        prevQuat = referenceTf.rotation;
    }

    void FixedUpdate()
    {
        Vector3 curTrans = referenceTf.position;
        Quaternion curQuat = referenceTf.rotation;

        Vector3 deltaTrans = (curTrans - prevTrans);
        Quaternion deltaQuat = Quaternion.Inverse(prevQuat) * curQuat;

        if (inputHandler.rightTouch >= 0.99f) {
            targetDeltaTf.position += deltaTrans;
            targetDeltaTf.rotation *= deltaQuat;
        }

        prevTrans = curTrans;
        prevQuat = curQuat;

        if (inputHandler.rightMenu >= 0.99) {
            targetDeltaTf.position = Vector3.zero;
            targetDeltaTf.rotation = Quaternion.identity;
        }
    }
}