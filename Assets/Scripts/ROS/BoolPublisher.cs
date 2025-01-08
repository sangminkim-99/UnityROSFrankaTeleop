using UnityEngine;

namespace RosSharp.RosBridgeClient
{
    public class BoolPublisher : UnityPublisher<MessageTypes.Std.Bool>
    {
        private MessageTypes.Std.Bool message;

        public bool data;

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
            message = new MessageTypes.Std.Bool
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