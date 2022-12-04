using Core;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public int CarsId { get; set; }
        public int BrandsId { get; set; }
        public int ColorsId { get; set; }
        public string Description { get; set; }
        public string ColorName { get; set; }
        public string BrandsName { get; set; }
        public int ModelYears { get; set; }
        public int DailyPrice { get; set; }
        public List<CarImage> ImagePath { get; set; }
    }
}
