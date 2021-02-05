using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Fundamentals.TypesAndOperators
{
    public class Dummy
    {
        public int A { get; set; }
        public int B { get; set; }
    }

    public class Token
    {
        List<Dummy> dummies = new List<Dummy>() { new Dummy { A = 1, B = 2 }, new Dummy { A = 3, B = 4 } };
        public Token()
        {
            //Dummy n = new Dummy();
            //n.A = 1;
            //n.B = 2;

            dummies.Add(new Dummy { A = 5, B = 6 });
            dummies.Add(new Dummy { A = 7, B = 8 });
        }
        public int sum(int a, int b)
        {
            return a + b;
        }

        //[0,1,2,3,4,5]  ,6,7,8......n]

        public int GetTotal()
        {
            int total = 0;

            for (int index = 0; index < dummies.Count-1; index++)
            {
                //total = total + sum(dummies[index].A, dummies[index].B);
                total += sum(dummies[index].A, dummies[index].B);
            };

            //  | "0" | <A=1,B=2> |
            //  | "1" | <A=3,B=4> |
            //  | "2" | <A=5,B=6> |
            //  | "3" | <A=7,B=8> |

            Dictionary<string, Dummy> dicDummies = new Dictionary<string, Dummy>();

            for (int index = 0; index < dicDummies.Count - 1; index++)
            {
                total += sum(dicDummies[index.ToString()].A, dicDummies[index.ToString()].B);
            };

            total = dummies.Sum((dummy) => dummy.A + dummy.B);

            dicDummies.Sum( kv => {
                return kv.Value.A + kv.Value.B;
            });

            return total;
        }
    }
}
