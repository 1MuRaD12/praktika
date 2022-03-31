using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Carlist
    {
        public Car[] cars;

        public int Count { get => cars.Length; }

        public Carlist()
        {
            cars = new Car[0];
        }

        public Car[] GetCars()
        {
            return cars;
        }
        public void Add( string word)
        {
            Array.Resize(ref cars, cars.Length + 1);
            cars[cars.Length - 1] = word;
        }
       
    }
}
