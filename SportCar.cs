﻿namespace NeedForSpeed
{
    public class SportCar : Car
    {
        public SportCar(int horsePower, double fuel)
            :base(horsePower,fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
            DefaulthFuelConsumption = 10;
        }
    }
}
