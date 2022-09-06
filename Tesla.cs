using System;
namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Telsa creeps by. *crickets*");
        }
        public override void Turn()
        {
            Console.WriteLine($"The Telsa quietly turns.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The Tesla quickly stops.\n");
        }
    }
}

