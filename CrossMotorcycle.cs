﻿
namespace NeedForSpeed
{
    public class CrossMotorcycle : Motorcycle
    {
        public CrossMotorcycle(int horsePower, double fuel)
            :base(horsePower,fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }
    }
}
