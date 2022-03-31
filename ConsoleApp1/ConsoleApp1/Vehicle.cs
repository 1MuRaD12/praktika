using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Vehicle
    {
        public string Color;
        public string Brand;
        public double Millage;
        public Vehicle(string color, string brand, double millage)
        {
            Color = color;
            Brand = brand;
            Millage = millage;
        }

        public virtual void Showinfo()
        {
            Console.WriteLine($"Brand:{Brand} Color:{Color} Milliage:{Millage}");
        }
    }
}
