namespace RobotPrototype
{
    public abstract class Robot : IRobotPrototype
    {
        public string ModelName { get; set; }
        public int BatteryCapacity { get; set; }
        public string SoftwareVersion { get; set; }

        protected Robot(string modelName, int batteryCapacity, string softwareVersion)
        {
            ModelName = modelName;
            BatteryCapacity = batteryCapacity;
            SoftwareVersion = softwareVersion;
        }

        public abstract IRobotPrototype Clone();

        public abstract void DisplayInfo();
    }
}