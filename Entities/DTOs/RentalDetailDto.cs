using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int CarsId { get; set; }
        public int CarsModel { get; set; }
        public string BrandsName { get; set; }
        public string ColorsName { get; set; }
        public int DailyPrice { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerCompanyName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnTime { get; set; }
    }
}
