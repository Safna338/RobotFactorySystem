using System;

namespace RobotPrototype
{
    public class ServiceRobot : Robot
    {
        public string ServiceTask { get; set; }

        public ServiceRobot(
            string modelName,
            int batteryCapacity,
            string softwareVersion,
            string serviceTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            ServiceTask = serviceTask;
        }

        public override IRobotPrototype Clone()
        {
            return new ServiceRobot(
                ModelName,
                BatteryCapacity,
                SoftwareVersion,
                ServiceTask
            );
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Service Robot");
            Console.WriteLine("Model Name: " + ModelName);
            Console.WriteLine("Battery Capacity: " + BatteryCapacity + " hours");
            Console.WriteLine("Software Version: " + SoftwareVersion);
            Console.WriteLine("Service Task: " + ServiceTask);
            Console.WriteLine();
        }
    }
}