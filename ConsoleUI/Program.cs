using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("Model Year\tColor\tBrand\tDescription\tDaily Price\n");

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.ModelYear + "\t\t" + car.ColorName + "\t" + car.BrandName + "\t" + car.Descriptions + "\t" + car.DailyPrice);
            }
        }
    }
}
