using System;

namespace RobotPrototypeDemo
{
    public class EntertainmentRobot : RobotPrototype
    {
        public string entertainmentFeature;

        public EntertainmentRobot(string modelName, int batteryCapacity, string softwareVersion, string entertainmentFeature)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            this.entertainmentFeature = entertainmentFeature;
        }

        public override RobotPrototype Clone()
        {
            return new EntertainmentRobot(this.modelName, this.batteryCapacity,
                this.softwareVersion, this.entertainmentFeature);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"EntertainmentRobot: {modelName} {batteryCapacity}h {softwareVersion} {entertainmentFeature}");
        }
    }
}