using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    internal class Car:Vehicle
    {
        public string Fuelcapacity;
        public int Currentfuel;
        public string Fuelfor1km;
        public static int Count = 0;

        public Car(string color, string brand, double millage, string fuelcapacity, int currentfuel, string fuelfor1km) : base(color, brand, millage)
        {
            Currentfuel = currentfuel;
            Fuelcapacity = fuelcapacity;
            Fuelfor1km = fuelfor1km;
        }

        public override void Showinfo()
        {
            Console.WriteLine($"Brand:{Brand} Color:{Color} Milliage:{Millage} Fuelcapacity:{Fuelcapacity} Currenfuel:{Currentfuel} fuelfor1km:{Fuelfor1km}");
        }
        public  void Drive()
        {
            
            if (Currentfuel >= Millage )
            {
                --Count;
                Count -= Currentfuel;

                
                Millage++;
            }
            else
            {
                Console.WriteLine("gedile bilmez");
            }
             
                      
        }

        public static implicit operator Car(string v)
        {

            Car car = new Car("black", "BMW", 5.6, "50l", 10, "8l");
            car.Fuelcapacity = v;
            car.Currentfuel = Count;
            return car;
            
        }
    }
}
