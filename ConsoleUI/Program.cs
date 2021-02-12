using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Database'de bulunan mevcut araç bilgilerinin tamamını getirir.
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelYear + " model " + car.Description + " => " + car.DailyPrice + " TL");
            }

            Console.ReadLine();
        }
    }
}
