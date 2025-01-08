using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RosSharp.RosBridgeClient
{
    public class GraspPublisher : BoolPublisher
    {
        public InputHandler inputHandler;

        protected override void FixedUpdate()
        {
            data = inputHandler.rightGrip >= 0.8;

            base.FixedUpdate();
        }
    }
}