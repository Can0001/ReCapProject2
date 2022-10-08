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
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                           join b in context.Brands
                           on c.BrandsId equals b.BrandsId
                           join c2 in context.Colors
                           on c.ColorsId equals c2.ColorId
                           select new CarDetailDto
                           {
                               BrandName = b.BrandsName,
                               ColorName = c2.ColorName,
                               DailyPrice = c.DailyPrice
                           };
                return result.ToList();

            }
        }
    }
}

