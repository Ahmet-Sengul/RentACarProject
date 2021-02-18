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
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            UserManager userManager = new UserManager(new EfUserDal());

            GetCarDetailDto(carManager);
            Console.WriteLine("________________________________________");
            UserAdd(userManager);

        }
        private static void UserAdd(UserManager userManager)
        {
            var result = userManager.Add(new User
            {
                FirstName = "Ahmet",
                LastName = "Şengül",
                Email = "ahmetwork7@gmail.com",
                Password = "8520"
            });
            Console.WriteLine(result.Message);
        }

        private static void GetCarDetailDto(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarId + "\t" + car.Descriptions + "\t" + car.ColorName + "\t" + car.DailyPrice);
            }
        }
    }
}
