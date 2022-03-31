using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Carim sayini daxil et");
            int carCount = Convert.ToInt32(Console.ReadLine());
            Car[] car1 = new Car[carCount];
            for (int i = 0; i < carCount; i++)
            {
                Console.WriteLine("COLOR");
                string color = Console.ReadLine();
                Console.WriteLine("BRAND");
                string brand = Console.ReadLine();
                Console.WriteLine("MILLAGE");
                double millage = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("FUELCAPACITY");
                double fuelcapacity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("CURRENTFUEL");
                double currentfuel = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("FUELFOR1KM");
                double fuelfor1km = Convert.ToInt32(Console.ReadLine());

              
                Car car = new Car(color, brand, millage, fuelcapacity, currentfuel, fuelfor1km);
            }

            bool check = true;
            while (check)
            {
                Console.WriteLine("1   Masinlari milliage gore filtirle");
                Console.WriteLine("2   Butun masinlari gosder");
                Console.WriteLine("3   Prosesi bitir");

                int num = Convert.ToInt32(Console.ReadLine());
                
                if(num == 1)
                {
                    Console.WriteLine("Min millage daxil et");
                    double minMillage = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Max millage daxil et");
                    double maxMillage = Convert.ToInt32(Console.ReadLine());
                    foreach (var item in FilterCars(car1,minMillage,maxMillage))
                    {
                        item.Showinfo();
                    }
                }
            }
                  
        }
   
        static Car[] FilterCars(Car[] cars,double minMillage,double maxMillage)
        {
            Car[] filterCar = new Car[0];

            foreach (var item in cars)
            {
                if(item.Millage>minMillage && item.Millage < maxMillage)
                {
                    Array.Resize(ref filterCar, filterCar.Length + 1);
                    filterCar[filterCar.Length - 1] = item;
                }
            }
            return cars;

        }
    }
}
