using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 225, ModelYear=2010, Description = " Toyota "},
                new Car{CarId = 2, BrandId = 2, ColorId = 2, DailyPrice = 110, ModelYear=2011, Description = " Audi A5 "},
                new Car{CarId = 3, BrandId = 2, ColorId = 1, DailyPrice = 225, ModelYear=2020, Description = " Audi A7 "},
                new Car{CarId = 4, BrandId = 3, ColorId = 2, DailyPrice = 350, ModelYear=2007, Description = " BMW 420i "},
                new Car{CarId = 5, BrandId = 3, ColorId = 1, DailyPrice = 155, ModelYear=2015, Description = " BMW "},
                new Car{CarId = 6, BrandId = 4, ColorId = 1, DailyPrice = 650, ModelYear=2015, Description = " Mercedes-Benz G63 "}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
