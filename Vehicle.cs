
namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
            DefaulthFuelConsumption = 1.25;
        }

        public double DefaulthFuelConsumption { get;protected set; }

        public virtual double FuelConsumption { get; set; }

        public double Fuel { get; set; }

        public int HorsePower { get; set; }

        public virtual void Drive(double kilometers)
        {
            double fuelNeeded = DefaulthFuelConsumption * kilometers;

            if (Fuel >= fuelNeeded)
            {
                Fuel -= DefaulthFuelConsumption *kilometers;
            }
        }

    }
}
