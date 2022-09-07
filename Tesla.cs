using System;
namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public float CurrentChargePercentage { get; set; }
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
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

