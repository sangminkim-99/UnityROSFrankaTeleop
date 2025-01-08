using UnityEngine;

namespace RosSharp.RosBridgeClient
{
    public class Float32Publisher : UnityPublisher<MessageTypes.Std.Float32>
    {
        private MessageTypes.Std.Float32 message;

        public float data;

        protected override void Start()
        {
            base.Start();
            InitializeMessage();
        }

        virtual protected void FixedUpdate()
        {
            UpdateMessage();
        }

        private void InitializeMessage()
        {
            message = new MessageTypes.Std.Float32
            {
                data = data
            };
        }

        private void UpdateMessage()
        {
            message.data = data;

            Publish(message);
        }
    }
}