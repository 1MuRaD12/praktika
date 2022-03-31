using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            Car car = new Car("Black", "BMW", 5.6, "50L", 10, "8L");
            car.Showinfo();
            car.Drive();

            while (check)
            {
                Console.WriteLine("1   Masinlari milliage gore filtirle");
                Console.WriteLine("2   Butun masinlari gosder");
                Console.WriteLine("3   Prosesi bitir");

                int num = Convert.ToInt32(Console.ReadLine());
                
                if(num == 1)
                {
                    string word = Console.ReadLine();
                    
                    
                    
                    
                }
            }
                  
        }
    }
}
