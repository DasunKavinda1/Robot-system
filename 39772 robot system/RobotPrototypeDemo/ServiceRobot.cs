using System;

namespace RobotPrototypeDemo
{
    public class ServiceRobot : RobotPrototype
    {
        public string serviceTask;

        public ServiceRobot(string modelName, int batteryCapacity, string softwareVersion, string serviceTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            this.serviceTask = serviceTask;
        }

        public override RobotPrototype Clone()
        {
            return new ServiceRobot(this.modelName, this.batteryCapacity,
                this.softwareVersion, this.serviceTask);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"ServiceRobot: {modelName} {batteryCapacity}h {softwareVersion} {serviceTask}");
        }
    }
}