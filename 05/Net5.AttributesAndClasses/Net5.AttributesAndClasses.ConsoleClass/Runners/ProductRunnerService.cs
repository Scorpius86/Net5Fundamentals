using Net5.AttributesAndClasses.ConsoleClass.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.AttributesAndClasses.ConsoleClass.Runners
{
    public class ProductRunnerService : RunnerService<Product>
    {
        public ProductRunnerService()
        {
            _item = new Product();
        }
        public override void DoWork()
        {
            Calc();
            Console.WriteLine($"Do Work : Product");
        }        

        public override void EndProcess()
        {
            Console.WriteLine($"End Process : Product");
        }

        private void Calc() { 
            //Todo
        }
    }
}
