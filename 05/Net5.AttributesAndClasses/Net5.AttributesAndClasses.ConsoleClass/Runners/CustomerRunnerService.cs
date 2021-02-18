using Net5.AttributesAndClasses.ConsoleClass.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.AttributesAndClasses.ConsoleClass.Runners
{
    public class CustomerRunnerService : RunnerService<Customer>
    {
        public CustomerRunnerService()
        {
            _item = new Customer();
        }
        public override void DoWork()
        {
            Console.WriteLine($"Do Work : Customer");
        }        

        public override void EndProcess()
        {
            Console.WriteLine($"End Process : Customer");
        }
        public override void Test()
        {
            Console.WriteLine($"Test : Customer");
        }
    }
}
