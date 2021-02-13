using Net5.AttributesAndClasses.LibraryClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.AttributesAndClasses.ConsoleClass
{
    [MyEspecial]
    public class Person : IPerson
    {
        public Person(String name)
        {
            Name = name;
        }
        public Person()
        {

        }
        public string Name { get; set; }
        public Address Address { get; set; }

        public void Run()
        {
            Console.WriteLine("Running");
        }

        public void Run(int i)
        {
            Console.WriteLine($"Running - i : {i}");
        }

        public void Run(string s)
        {
            Console.WriteLine($"Running - s : {s}");
        }
    }
}
