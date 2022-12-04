using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarsId = 1, ColorsId=1,BrandsId=1,DailyPrice=100,ModelYears=2000,Description="Temiz"},
                new Car{CarsId = 2, ColorsId=1,BrandsId=1,DailyPrice=220,ModelYears=2002,Description="Daha Temiz"},
                new Car{CarsId = 3, ColorsId=2,BrandsId=2,DailyPrice=330,ModelYears=2005,Description="Daha Daha Temiz"},
                new Car{CarsId = 4, ColorsId=3,BrandsId=2,DailyPrice=330,ModelYears=2006,Description="Çok Daha Temiz"},
                new Car{CarsId = 5, ColorsId=4,BrandsId=2,DailyPrice=400,ModelYears=2009,Description="Aşırı Çok Daha Temiz"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public bool Any(Expression<Func<Car, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarsId == car.CarsId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarsId == carId).ToList();
        }

        public CarDetailDto GetCarDetails(int id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public CarDetailDto GetDetail(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUptade = _cars.SingleOrDefault(c => c.CarsId == car.CarsId);
            carToUptade.BrandsId = car.BrandsId;
            carToUptade.DailyPrice = car.DailyPrice;
            carToUptade.ModelYears = car.ModelYears;
            carToUptade.Description = car.Description;

        }

       
    }
}
