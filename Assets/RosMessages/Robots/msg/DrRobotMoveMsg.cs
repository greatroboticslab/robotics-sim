//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Robots
{
    [Serializable]
    public class DrRobotMoveMsg : Message
    {
        public const string k_RosMessageName = "Robots/DrRobotMove";
        public override string RosMessageName => k_RosMessageName;

        public string move_command;

        public DrRobotMoveMsg()
        {
            this.move_command = "";
        }

        public DrRobotMoveMsg(string move_command)
        {
            this.move_command = move_command;
        }

        public static DrRobotMoveMsg Deserialize(MessageDeserializer deserializer) => new DrRobotMoveMsg(deserializer);

        private DrRobotMoveMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.move_command);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.move_command);
        }

        public override string ToString()
        {
            return "DrRobotMoveMsg: " +
            "\nmove_command: " + move_command.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
