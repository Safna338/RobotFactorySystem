using System;

namespace RobotPrototype
{
    public class IndustrialRobot : Robot
    {
        public string IndustrialTask { get; set; }

        public IndustrialRobot(
            string modelName,
            int batteryCapacity,
            string softwareVersion,
            string industrialTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            IndustrialTask = industrialTask;
        }

        public override IRobotPrototype Clone()
        {
            return new IndustrialRobot(
                ModelName,
                BatteryCapacity,
                SoftwareVersion,
                IndustrialTask
            );
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Industrial Robot");
            Console.WriteLine("Model Name: " + ModelName);
            Console.WriteLine("Battery Capacity: " + BatteryCapacity + " hours");
            Console.WriteLine("Software Version: " + SoftwareVersion);
            Console.WriteLine("Industrial Task: " + IndustrialTask);
            Console.WriteLine();
        }
    }
}