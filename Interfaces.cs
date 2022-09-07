using System;

namespace Garage
{
    public interface IElectricVehicle
    {
        double BatteryKWh { get; set; }
        float CurrentChargePercentage { get; set; }
        void ChargeBattery();

    }

    public interface IGasVehicle
    {
        double FuelCapacity { get; set; }
        void RefuelTank();
        float CurrentTankPercentage { get; set; }
    }



}