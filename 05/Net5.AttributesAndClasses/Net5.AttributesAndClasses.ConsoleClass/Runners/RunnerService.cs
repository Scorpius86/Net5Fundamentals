using Net5.AttributesAndClasses.ConsoleClass.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.AttributesAndClasses.ConsoleClass.Runners
{
    public abstract class RunnerService<T>
    {
        public T _item { get; set; }

        public void Run()
        {
            DoWork();
            Test();
            EndProcess();
        }

        public abstract void DoWork();
        public abstract void EndProcess();
        public virtual void Test()
        {
            Console.WriteLine($"Test : {_item.GetType().Name}");
        }
       
    }
}
