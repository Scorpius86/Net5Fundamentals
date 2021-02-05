using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Fundamentals.TypesAndOperators
{
    public partial class Person:Human
    {
        //readonly public string EyesColor;
        public string EyesColor { get;  init}
        //public string EyesColor { get; set; }
        public string LipsColor { get; set; }

        public void Speak()
        {

        }

        public void Eat()
        {
            
        }

        partial void ChangeName();


        
    }
}
