using System;
namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies past. Zoooooom!");
        }
        public override void Turn()
        {
            Console.WriteLine($"The Cessna swiftly turns.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The Cessna drops to the runway and traverses the runway to a stop.\n");
        }
    }
}