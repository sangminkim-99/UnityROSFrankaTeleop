/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Sensor
{
    public class LaserEcho : Message
    {
        public const string RosMessageName = "sensor_msgs/msg/LaserEcho";

        //  This message is a submessage of MultiEchoLaserScan and is not intended
        //  to be used separately.
        public float[] echoes { get; set; }
        //  Multiple values of ranges or intensities.
        //  Each array represents data from the same angle increment.

        public LaserEcho()
        {
            this.echoes = new float[0];
        }

        public LaserEcho(float[] echoes)
        {
            this.echoes = echoes;
        }
    }
}
#endif
