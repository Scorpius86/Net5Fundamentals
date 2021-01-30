using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Fundamentals.TypesAndOperators
{
    public class MyClass
    {
        public int Age { get; set; } = 10;

        public MyClass()
        {
            Pet pet = new Pet("Dog");
        }
    }

    public record Pet(string Name)
    {
        public void SherdTheFurniture()
        {
            Console.WriteLine($"Shredding furniture {Name}");
        }
    }
}
