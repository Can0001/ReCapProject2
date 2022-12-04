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
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int carsId);
        IDataResult<List<Car>> GetCarsByBrandId(int brnadId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailDto>> GetCarDeatilsById(int carId);
        IDataResult<List<CarDetailDto>> GetCarDeatilsByBrand(int brandId);
        IDataResult<List<CarDetailDto>> GetCarDeatilsByColor(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetailsByColorAndByBrand(int colorId, int brandId);

        IResult AddTransactionalTest(Car car);

    }
}
