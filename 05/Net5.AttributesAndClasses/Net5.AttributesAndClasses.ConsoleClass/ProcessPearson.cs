using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.AttributesAndClasses.ConsoleClass
{
    public class ProcessPearson
    {
        public void ProcessNameWithReference(IPerson person)
        {            
            person.Name = person.Name + " - Process";
        }
        public void ProcessNameWithoutReference(IPerson p)
        {
            Person person = new Person(p.Name);
            person.Name = person.Name + " - Process";
        }

        public void MyMethodOne(int i)
        {
            Console.WriteLine($"One - El valor de i : {i}");
        }
        public void MyMethodTwo(int i)
        {
            Console.WriteLine($"Two - El valor de i : {i}");
        }
    }
}
