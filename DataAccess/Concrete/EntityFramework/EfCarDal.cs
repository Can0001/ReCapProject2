using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (var context = new ReCapContext())
            {
                var result = from car in filter != null ? context.Cars.Where(filter) : context.Cars
                             join color in context.Colors
                             on car.ColorsId equals color.ColorId
                             join brand in context.Brands
                             on car.BrandsId equals brand.BrandsId
                             select new CarDetailDto
                             {
                                 CarsId = car.CarsId,
                                 BrandsId=brand.BrandsId,
                                 ColorsId=color.ColorId,
                                 BrandsName = brand.BrandsName,
                                 ColorName = color.ColorName,
                                 ModelYears = car.ModelYears,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 ImagePath = context.CarImages.Where(c => c.CarsId == car.CarsId).ToList()
                             };
                    return result.ToList();

            }
        }

        public CarDetailDto GetDetail(Expression<Func<Car, bool>> filter)
        {
            using (var context = new ReCapContext())
            {
                var result = from car in context.Cars.Where(filter)
                             join color in context.Colors
                             on car.ColorsId equals color.ColorId
                             join brand in context.Brands
                             on car.BrandsId equals brand.BrandsId
                             select new CarDetailDto
                             {
                                 CarsId = car.CarsId,
                                 BrandsName = brand.BrandsName,
                                 ColorName = color.ColorName,
                                 ModelYears = car.ModelYears,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 ImagePath = context.CarImages.Where(c => c.CarsId == car.CarsId).ToList()
                             };
                return result.SingleOrDefault();
            }
        }
    }
}

