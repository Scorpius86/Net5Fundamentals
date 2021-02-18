using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.AttributesAndClasses.ConsoleClass.Entidades
{
    public class Sale
    {
        public int  Id { get; set; }
        public string Description { get; set; }
        public Decimal Total { get; set; }
    }
}
