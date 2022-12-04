using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {//post(add,delete,update) get(-getaall getbycarid-getbyimageid)
     //    private static IWebHostEnvironment _webHostEnvironment;

        //    public CarImagesController(IWebHostEnvironment webHostEnvironment)
        //    {
        //        _webHostEnvironment= webHostEnvironment;
        //    }

        //    [HttpPost]
        //    [Route("upload")]
        //    public async Task<string> Upload([FromForm]UploadFile obj)
        //    {
        //        if (obj.files.Length>0)
        //        {
        //            try
        //            {
        //                if (!Directory.Exists(_webHostEnvironment.WebRootPath+"\\Images\\"))
        //                {
        //                    Directory.CreateDirectory(_webHostEnvironment.WebRootPath + "\\Images\\");
        //                }
        //                using(FileStream fileStream=System.IO.File.Create(_webHostEnvironment.WebRootPath+ "\\Images\\" + obj.files.FileName))
        //                {
        //                    obj.files.CopyTo(fileStream);
        //                    fileStream.Flush();
        //                    return "\\Images\\"+obj.files.FileName;
        //                }
        //            }
        //            catch (Exception ex)
        //            {

        //                return ex.ToString();
        //            }
        //        }
        //        else
        //        {
        //            return "Upload Failed";
        //        }
        //    }

        //}

        ICarImageService _carImageService;
        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }
        [HttpPost("add")]
        public IActionResult Add(IFormFile file, int carsId)
        {
            var result = _carImageService.Add(file, carsId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {
            var result = _carImageService.Delete(id);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("update")]
        public IActionResult Update(int id, [FromForm] IFormFile file)
        {
            var result = _carImageService.Update(file, id);
            if (!result.Success) return BadRequest(result);

            return Ok(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallbycarid")]
        public IActionResult GetAllByCarId(int carId)
        {
            var result = _carImageService.GetAllByCarId(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return Ok(result);
        }
        [HttpGet("getbyimageid")]
        public IActionResult GetByImageId(int imageId)
        {
            var result = _carImageService.GetByImageId(imageId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}