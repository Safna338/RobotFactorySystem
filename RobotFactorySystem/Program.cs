using System;

namespace RobotPrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Original Service Robot
            ServiceRobot serviceRobot = new ServiceRobot(
                "SR-100",
                8,
                "1.0",
                "Assist Patients"
            );

            Console.WriteLine("=== Original Service Robot ===");
            serviceRobot.DisplayInfo();

            // Clone Service Robot
            ServiceRobot clonedServiceRobot =
                (ServiceRobot)serviceRobot.Clone();

            // Customize cloned robot
            clonedServiceRobot.ModelName = "SR-101";
            clonedServiceRobot.BatteryCapacity = 12;
            clonedServiceRobot.SoftwareVersion = "1.1";

            Console.WriteLine("=== Cloned & Customized Service Robot ===");
            clonedServiceRobot.DisplayInfo();


            // Original Industrial Robot
            IndustrialRobot industrialRobot = new IndustrialRobot(
                "IR-200",
                15,
                "2.0",
                "Welding"
            );

            Console.WriteLine("=== Original Industrial Robot ===");
            industrialRobot.DisplayInfo();

            IndustrialRobot clonedIndustrialRobot =
                (IndustrialRobot)industrialRobot.Clone();

            clonedIndustrialRobot.ModelName = "IR-201";
            clonedIndustrialRobot.BatteryCapacity = 20;
            clonedIndustrialRobot.SoftwareVersion = "2.1";

            Console.WriteLine("=== Cloned & Customized Industrial Robot ===");
            clonedIndustrialRobot.DisplayInfo();


            // Original Entertainment Robot
            EntertainmentRobot entertainmentRobot =
                new EntertainmentRobot(
                    "ER-300",
                    6,
                    "3.0",
                    "Dance and Interact"
                );

            Console.WriteLine("=== Original Entertainment Robot ===");
            entertainmentRobot.DisplayInfo();

            EntertainmentRobot clonedEntertainmentRobot =
                (EntertainmentRobot)entertainmentRobot.Clone();

            clonedEntertainmentRobot.ModelName = "ER-301";
            clonedEntertainmentRobot.BatteryCapacity = 10;
            clonedEntertainmentRobot.SoftwareVersion = "3.1";

            Console.WriteLine("=== Cloned & Customized Entertainment Robot ===");
            clonedEntertainmentRobot.DisplayInfo();

            Console.ReadLine();
        }
    }
}
