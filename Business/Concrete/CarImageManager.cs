using Business.Abstract;
using Business.Constans;
using Business.Constants;
using Core.Aspects.Autofac.Transaction;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IFileHelper _fileHelper;
        string _baseImagePath = @"wwwroot\\Images\\";
        string _defaultImagePath = "images/DefaultImage.jpg";

        public CarImageManager(ICarImageDal carImageDal, IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFormFile file, int carId)
        {
            IResult result = BusinessRules.Run(CheckCarImageLimit(carId));
            if (result != null)
            {
                return result;
            }

            var carImage = new CarImage

            {
                CarsId = carId,
                DateDay = DateTime.Now,
                ImagePath = _fileHelper.Add(file)
            };

            _carImageDal.Add(carImage);

            return new SuccessResult(Messages.ImageAdded);
        }

        [TransactionScopeAspect]
        public IResult Update(IFormFile file, int id)
        {
            var carImage = _carImageDal.Get(ci => ci.Id == id);
            carImage.ImagePath = _fileHelper.Update(file, carImage.ImagePath);

            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.ImageUpdated);
        }

        [TransactionScopeAspect]
        public IResult Delete(int id)
        {
            var carImage = _carImageDal.Get(ci => ci.Id == id);
            _fileHelper.Delete(carImage.ImagePath);

            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.ImageDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetAllByCarId(int carId)
        {
            var result = _carImageDal.GetAll(ci => ci.CarsId == carId);
            if (result.Count == 0) result.Add(new CarImage { ImagePath = _defaultImagePath });
            return new SuccessDataResult<List<CarImage>>(result, Messages.CarListed);
        }

        public IDataResult<CarImage> GetByImageId(int imageId)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.Id == imageId));
        }

        private IDataResult<List<CarImage>> GetDefaultImage(int carId)
        {

            List<CarImage> carImage = new List<CarImage>();
            carImage.Add(new CarImage { CarsId = carId, DateDay = DateTime.Now, ImagePath = _defaultImagePath });
            return new SuccessDataResult<List<CarImage>>(carImage);
        }

        private IResult CheckCarImageLimit(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarsId == carId);
            if (result.Count > 0)
            {
                if (result.Count > 5)
                {
                    return new ErrorResult(Messages.ImageLimitHasBeenExceeded);
                }
            }
            var t = new SuccessResult();
            return new SuccessResult();
        }
    }
}