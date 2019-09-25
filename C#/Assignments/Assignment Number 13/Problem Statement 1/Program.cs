using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MarvellousArithmatic;

namespace Problem_Statement_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            int value1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            int value2 = Convert.ToInt32(Console.ReadLine());

            Class1 obj = new Class1();

            del dobj = new del(obj.Add);

            dobj += new del(obj.Sub);

            dobj += new del(obj.Mul);

            dobj += new del(obj.Div);

            Console.WriteLine("Division is:{0}", dobj(value1, value2));
            dobj -= new del(obj.Div);

            Console.WriteLine("Multiplication is:{0}", dobj(value1, value2));
            dobj -= new del(obj.Mul);

            Console.WriteLine("Substration is:{0}", dobj(value1, value2));
            dobj -= new del(obj.Sub);

            Console.WriteLine("Addition is:{0}", dobj(value1, value2));
            dobj -= new del(obj.Add);
        }
    }
}
