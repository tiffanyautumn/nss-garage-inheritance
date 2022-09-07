using System;
namespace Garage
{
    public class Ram : Vehicle, IGasVehicle// Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public float CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        public Ram()
        {
            CurrentTankPercentage = 50;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram limps past. clunk clunk clunk");
        }
        public override void Turn()
        {
            Console.WriteLine($"The Ram takes a wide turn.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The Ram slowly stops.\n");
        }
    }
}