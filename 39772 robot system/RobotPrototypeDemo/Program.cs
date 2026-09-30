using System;

namespace RobotPrototypeDemo
{
    public class Program
    {
        public static void Main(String[] args)
        {
            ServiceRobot service1 = new ServiceRobot("HelpBot-X1", 8, "v1.0", "Serving food");
            service1.DisplayDetails();

            ServiceRobot service2 = (ServiceRobot)service1.Clone();
            service2.batteryCapacity = 10;
            service2.softwareVersion = "v1.1";
            service2.DisplayDetails();

            IndustrialRobot industrial1 = new IndustrialRobot("WeldMaster-500", 12, "v2.1", "Welding");
            industrial1.DisplayDetails();

            IndustrialRobot industrial2 = (IndustrialRobot)industrial1.Clone();
            industrial2.softwareVersion = "v2.2";
            industrial2.DisplayDetails();

            EntertainmentRobot fun1 = new EntertainmentRobot("FunBot-Z", 6, "v1.5", "Dancing");
            fun1.DisplayDetails();

            EntertainmentRobot fun2 = (EntertainmentRobot)fun1.Clone();
            fun2.batteryCapacity = 9;
            fun2.DisplayDetails();

            Console.WriteLine("--- originals after customizing clones ---");
            service1.DisplayDetails();
            industrial1.DisplayDetails();
            fun1.DisplayDetails();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}