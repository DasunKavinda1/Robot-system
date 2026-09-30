using System;

namespace RobotPrototypeDemo
{
    public class IndustrialRobot : RobotPrototype
    {
        public string industrialTask;

        public IndustrialRobot(string modelName, int batteryCapacity, string softwareVersion, string industrialTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            this.industrialTask = industrialTask;
        }

        public override RobotPrototype Clone()
        {
            return new IndustrialRobot(this.modelName, this.batteryCapacity,
                this.softwareVersion, this.industrialTask);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"IndustrialRobot: {modelName} {batteryCapacity}h {softwareVersion} {industrialTask}");
        }
    }
}