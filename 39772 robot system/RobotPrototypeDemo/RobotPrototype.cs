using System;

namespace RobotPrototypeDemo
{
    public abstract class RobotPrototype
    {
        public string modelName;
        public int batteryCapacity;
        public string softwareVersion;

        public RobotPrototype(string modelName, int batteryCapacity, string softwareVersion)
        {
            this.modelName = modelName;
            this.batteryCapacity = batteryCapacity;
            this.softwareVersion = softwareVersion;
        }

        public abstract RobotPrototype Clone();
        public abstract void DisplayDetails();
    }
}