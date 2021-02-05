using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Fundamentals.TypesAndOperators
{
    public class Varianza
    {
        public Varianza()
        {
            
        }

        public void Covarianza()
        {
            IEnumerable<Derived> d = new List<Derived>();
            IEnumerable<Base> b = d;
        }

        public void write(Base target)
        {
            Console.WriteLine(target.GetType().Name);
        }

        public void Contravarianza()
        {
            //Action<Base> b = write;
            Action<Base> b= (target) =>{ Console.WriteLine(target.GetType().Name); };
            Action<Derived> d = b;
        }
    }
}
