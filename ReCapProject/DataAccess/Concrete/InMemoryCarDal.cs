using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1, ColorId=1,ModelYear="2015",DailyPrice=50000,Description="Hasarsız"},
                 new Car{Id=2,BrandId=1, ColorId=2,ModelYear="2017",DailyPrice=70000,Description="Hasarsız"},
                  new Car{Id=3,BrandId=2, ColorId=2,ModelYear="2020",DailyPrice=750000,Description="Gıcır Gıcır"},
                   new Car{Id=4,BrandId=3, ColorId=1,ModelYear="2019",DailyPrice=65000,Description="Hasarsız"},
                    new Car{Id=5,BrandId=4, ColorId=3,ModelYear="2019",DailyPrice=88000,Description="Hasarsız"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
