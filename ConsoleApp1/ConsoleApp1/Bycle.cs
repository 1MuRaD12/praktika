using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Bycle:Vehicle
    {
        public static int Count = 0;

        public Bycle(string color, string brand, double millage) : base(color, brand, millage)
        {

        }

        public void Drive()
        {
            Count++;
            Millage = Count;
        }
        public override void Showinfo()
        {
            Console.WriteLine($"Brand:{Brand} Color:{Color} Milliage:{Millage}");
        }
    }
}
