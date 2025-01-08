using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RosSharp.RosBridgeClient
{
    public class TouchClickPublisher : BoolPublisher
    {
        public InputHandler inputHandler;

        protected override void FixedUpdate()
        {
            data = inputHandler.rightTouchClick > 0.5f;

            base.FixedUpdate();
        }
    }
}