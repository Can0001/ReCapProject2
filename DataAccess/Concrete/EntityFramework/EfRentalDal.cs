using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetail()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars
                             on rental.Id equals car.CarsId
                             join customer in context.Customers
                             on rental.CustomersId equals customer.CustomersId
                             join user in context.Users
                             on customer.UserId equals user.UserId
                             join brand in context.Brands
                             on car.BrandsId equals brand.BrandsId
                             join color in context.Colors
                             on car.ColorsId equals color.ColorId
                             select new RentalDetailDto
                             {
                                 CarsId = rental.CarsId,
                                 CarsModel = car.ModelYears,
                                 BrandsName = brand.BrandsName,
                                 ColorsName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 CustomerCompanyName = customer.CompanyName,
                                 CustomerFirstName =  user.FirstName,
                                 CustomerLastName = user.LastName,
                                 RentDate = rental.RentDate,
                                 ReturnTime = rental.ReturnDate
                                 

                             };

                return result.ToList();
            }
        }
    }
}
