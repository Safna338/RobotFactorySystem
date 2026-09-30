using System;

namespace RobotPrototype
{
    public class EntertainmentRobot : Robot
    {
        public string EntertainmentFeature { get; set; }

        public EntertainmentRobot(
            string modelName,
            int batteryCapacity,
            string softwareVersion,
            string entertainmentFeature)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            EntertainmentFeature = entertainmentFeature;
        }

        public override IRobotPrototype Clone()
        {
            return new EntertainmentRobot(
                ModelName,
                BatteryCapacity,
                SoftwareVersion,
                EntertainmentFeature
            );
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Entertainment Robot");
            Console.WriteLine("Model Name: " + ModelName);
            Console.WriteLine("Battery Capacity: " + BatteryCapacity + " hours");
            Console.WriteLine("Software Version: " + SoftwareVersion);
            Console.WriteLine("Entertainment Feature: " + EntertainmentFeature);
            Console.WriteLine();
        }
    }
}