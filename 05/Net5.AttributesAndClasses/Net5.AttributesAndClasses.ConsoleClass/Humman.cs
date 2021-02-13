using Net5.AttributesAndClasses.LibraryClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.AttributesAndClasses.ConsoleClass
{
    public class Humman : IPerson
    {
        public Address Address { get; set ; }
        public string Name { get ; set ; }

        public void Run()
        {
            Console.WriteLine("Running Humman");
        }

        public void Run(int i)
        {
            Console.WriteLine($"Running Humman i : {i}");
        }

        public void Run(string s)
        {
            Console.WriteLine($"Running Humman s : {s}");
        }
    }
}
