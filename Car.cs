
namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        public Car(int horsePower, double fuel)
            :base(horsePower,fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
            DefaulthFuelConsumption = 3;
        }
    }
}
