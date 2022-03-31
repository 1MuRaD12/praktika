using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Bycle:Vehicle
    {

        public Bycle(string color, string brand, double millage) : base(color, brand, millage)
        {

        }

        public void Drive()
        {
            Millage++;
        }
        public override void Showinfo()
        {
            Console.WriteLine($"Brand:{Brand} Color:{Color} Milliage:{Millage}");
        }
    }
}
