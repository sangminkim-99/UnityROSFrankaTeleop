/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

using RosSharp.RosBridgeClient.MessageTypes.UniqueIdentifier;
using RosSharp.RosBridgeClient.MessageTypes.BuiltinInterfaces;

namespace RosSharp.RosBridgeClient.MessageTypes.Action
{
    public class GoalInfo : Message
    {
        public const string RosMessageName = "action_msgs/msg/GoalInfo";

        //  Goal ID
        public UUID goal_id { get; set; }
        //  Time when the goal was accepted
        public Time stamp { get; set; }

        public GoalInfo()
        {
            this.goal_id = new UUID();
            this.stamp = new Time();
        }

        public GoalInfo(UUID goal_id, Time stamp)
        {
            this.goal_id = goal_id;
            this.stamp = stamp;
        }
    }
}
#endif
