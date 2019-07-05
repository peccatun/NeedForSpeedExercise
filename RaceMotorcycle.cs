
namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, double fuel)
            :base(horsePower,fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
            DefaulthFuelConsumption = 8;
        }
    }
}
