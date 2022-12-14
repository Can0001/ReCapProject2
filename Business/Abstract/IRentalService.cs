using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetById(int Id);
        IDataResult<List<RentalDetailDto>> GetRentalDetail();
        IDataResult<List<Rental>> GetRentedCars();
        IDataResult<List<Rental>> GetNotRentedCars();
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
    }
}
