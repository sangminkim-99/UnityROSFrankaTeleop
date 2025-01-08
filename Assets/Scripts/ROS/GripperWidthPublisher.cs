using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RosSharp.RosBridgeClient
{
    public class GripperWidthPublisher : Float32Publisher
    {
        public InputHandler inputHandler;

        protected override void FixedUpdate()
        {
            data = Mathf.Max(0.8f - inputHandler.rightGrip, 0.0f) * 0.1f;
            
            base.FixedUpdate();
        }
    }
}