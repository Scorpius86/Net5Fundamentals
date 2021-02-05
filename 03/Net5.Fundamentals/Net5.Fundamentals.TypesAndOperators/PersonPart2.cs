using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Fundamentals.TypesAndOperators
{
    public partial class Person
    {
        public int Arms { get; set; }
        public void Run()
        {            

        }

        partial void ChangeName()
        {
            this.Eat();
        }
    }
}
