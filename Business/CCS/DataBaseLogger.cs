using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CCS
{
    public class DataBaseLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("VeriTabanına Loglandı");
        }
    }
}
