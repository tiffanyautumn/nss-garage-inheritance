using System;
namespace Garage
{
    public class Zero : Vehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips past. bewwwwww");
        }
        public override void Turn()
        {
            Console.WriteLine($"The Zero nimbly turns.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The Zero stops on a dime.\n");
        }
    }
}