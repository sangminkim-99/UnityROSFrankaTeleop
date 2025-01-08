/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Rosapi
{
    public class TypeDef : Message
    {
        public const string RosMessageName = "rosapi_msgs/msg/TypeDef";

        public string type { get; set; }
        public string[] fieldnames { get; set; }
        public string[] fieldtypes { get; set; }
        public int[] fieldarraylen { get; set; }
        public string[] examples { get; set; }
        public string[] constnames { get; set; }
        public string[] constvalues { get; set; }

        public TypeDef()
        {
            this.type = "";
            this.fieldnames = new string[0];
            this.fieldtypes = new string[0];
            this.fieldarraylen = new int[0];
            this.examples = new string[0];
            this.constnames = new string[0];
            this.constvalues = new string[0];
        }

        public TypeDef(string type, string[] fieldnames, string[] fieldtypes, int[] fieldarraylen, string[] examples, string[] constnames, string[] constvalues)
        {
            this.type = type;
            this.fieldnames = fieldnames;
            this.fieldtypes = fieldtypes;
            this.fieldarraylen = fieldarraylen;
            this.examples = examples;
            this.constnames = constnames;
            this.constvalues = constvalues;
        }
    }
}
#endif
