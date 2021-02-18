using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net5.FunctionalProgramming.Samples
{
    public class Lambda
    {
        delegate int operationDelegate(int a, int b);
        Func<string, string> selector = (str) => str.ToUpper();
        Action<string> messageTarget;


        //private int suma(int a,int b)
        //{
        //    return a + b;
        //}

        public void DoWork()
        {
            Print(5, 5, (a,b)=> a + b );
            Print(4, 2, (x, y) => x * y);
            Print(6, 6, (a, b) => a + b);
            Print(144, 666, (x, y) => x * y);

            FunctionDelegate();
            messageTarget = ShowMessage;
            messageTarget("Message : ShowMessage");

            messageTarget = Console.WriteLine;
            messageTarget("Message : Console.WriteLine");

            List<int> list = new List<int>();
            IEnumerable<string> enumerable;
            ICollection<string> collection;


            var test = list
                         .Where(l => l == 2)
                         .Select(s => s)
                         .Sum(s=>s);

        }

        private void Print(int a , int b , operationDelegate operation)
        {
            int result = operation(a, b);
            Console.WriteLine($"Imprmiendo : {result}");
        }

        private void FunctionDelegate()
        {
            string[] words = { "Naranja", "Manzana", "Articulo", "Elefante" };
            IEnumerable<string> result = words.Select(selector);
            result.ToList().ForEach(word => Console.WriteLine(word));
        }

        private void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
