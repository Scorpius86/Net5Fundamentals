using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Fundamentals.Data.Client.MVC.Data
{
    public class Customer
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string District { get; set; }
        public string Sex { get; set; }
        public int Dni { get; set; }
        public string Ruc { get; set; }
        public int Telehone { get; set; }
        public int Mobile { get; set; }
    }
}
