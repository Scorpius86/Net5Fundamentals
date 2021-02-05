using System;
using System.Linq;

namespace Net5.Fundamentals.TypesAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            float temperature;
            string name;
            MyClass myClass;

            //Initialize
            char firtsLetter = 'C';
            var limit = 3;
            
            int[] source = { 0, 1, 2, 3, 4, 5 };
            var query = from item in source
                        where item <= limit
                        select item;

            var decimalLiteral = 42.0D;
            var hexLiteral = 0x2A;
            var binaryLiteral = 0b_0010_1010;

            Season s = Season.Spring;
            ErrorCode e = ErrorCode.OutLierReading;


            (string A, double B,double C) t3 = ("Erick", 3.0,4.0);
            Console.WriteLine(nameof(t3) +  ":" + t3.A + " - " + t3.B + " - " + t3.C) ;
            Console.WriteLine($"{nameof(t3)} : {t3.A} - {t3.B} - {t3.C}");

            int? c = 7;
            string sNull = null;

            if (c.HasValue)
            {
                Console.WriteLine(c.Value);
            }

            Derived d = new Derived();
            Base b = d;

            object o = new object();
            Base bb = (Base)o;

            int aConv = Convert.ToInt32("0");
            int bConv = int.Parse("12");

            int i = 0;
            i++;// i= i+1
            i--; // i = i-1

            int mod = 8 % 2;

            bool logic = false;
            bool logicNegative = !logic;

            bool opeLog = (logic & logicNegative);
            opeLog = (logic && logicNegative);

            opeLog = (logic | logicNegative);
            opeLog = (logic || logicNegative);

            var rand = new Random();
            var condition = rand.NextDouble() > 0.5;

            int? x;
            if (condition)
            {
                x = 12;
            }
            else
            {
                x = null;
            }

            x = condition ? 12 : null;

            int? aTer = null;
            int bTer;

            if (aTer.HasValue)
            {
                bTer = aTer.Value;
            }
            else
            {
                bTer = 1;
            }

            bTer = aTer ?? 1;

            Person p = new Person()
            {
                EyesColor = "Blue"
            };

            //p.EyesColor = "Green";
        }
    }
}
