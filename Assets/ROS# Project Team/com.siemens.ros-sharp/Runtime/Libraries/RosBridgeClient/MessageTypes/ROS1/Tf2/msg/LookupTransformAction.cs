/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if !ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Tf2
{
    public class LookupTransformAction : Message
    {
        public const string RosMessageName = "tf2_msgs/LookupTransformAction";

        //  ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
        public LookupTransformActionGoal action_goal { get; set; }
        public LookupTransformActionResult action_result { get; set; }
        public LookupTransformActionFeedback action_feedback { get; set; }

        public LookupTransformAction()
        {
            this.action_goal = new LookupTransformActionGoal();
            this.action_result = new LookupTransformActionResult();
            this.action_feedback = new LookupTransformActionFeedback();
        }

        public LookupTransformAction(LookupTransformActionGoal action_goal, LookupTransformActionResult action_result, LookupTransformActionFeedback action_feedback)
        {
            this.action_goal = action_goal;
            this.action_result = action_result;
            this.action_feedback = action_feedback;
        }
    }
}
#endif
