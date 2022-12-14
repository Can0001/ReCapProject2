using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        [Key]
        public int CarsId{ get; set; }
        public int BrandsId { get; set; }
        public int ColorsId { get; set; }
        public int ModelYears { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }

    }
}
