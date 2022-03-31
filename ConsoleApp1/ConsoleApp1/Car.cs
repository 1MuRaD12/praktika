using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    internal class Car:Vehicle
    {
        public double Fuelcapacity;
        public double Currentfuel;
        public double Fuelfor1km;
        public static int Count = 0;

        public Car(string color, string brand, double millage, double fuelcapacity, double currentfuel, double fuelfor1km) : base(color, brand, millage)
        {
            Currentfuel = currentfuel;
            Fuelcapacity = fuelcapacity;
            Fuelfor1km = fuelfor1km;
        }

        public override void Showinfo()
        {
            Console.WriteLine($"Brand:{Brand} Color:{Color} Milliage:{Millage} Fuelcapacity:{Fuelcapacity} Currenfuel:{Currentfuel} fuelfor1km:{Fuelfor1km}");
        }
        public void Drive(double km)
        {

            if (km * Fuelfor1km < Currentfuel)
            {
                Currentfuel -= km * Fuelfor1km;
                Millage += km;
            }
            else
            {
                Console.WriteLine("gedile bilmez");
            }
             
                      
        }

        
    }
}
