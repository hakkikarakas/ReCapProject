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
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car{CarId=1,BrandId="BMW",ColorId="Siyah",ModelYear=2010,DailyPrice=150,Description="Standart Paket" },
            new Car{CarId=2,BrandId="Benz",ColorId="Gri",ModelYear=2015,DailyPrice=200,Description="Full Paket" },
            new Car{CarId=3,BrandId="VW",ColorId="Kırmızı",ModelYear=2017,DailyPrice=70,Description="Standart Paket" },
            new Car{CarId=4,BrandId="OnukSazanLM",ColorId="Siyah",ModelYear=2003,DailyPrice=150,Description="-----" },
            new Car{CarId=5,BrandId="BMC",ColorId="Beyaz",ModelYear=2008,DailyPrice=50,Description="Standart Paket" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c =>c.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
