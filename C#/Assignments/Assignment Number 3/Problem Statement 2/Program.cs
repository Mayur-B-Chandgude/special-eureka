using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int Del(int No1,int No2);

namespace Problem_Statement_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            int value1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            int value2 = Convert.ToInt16(Console.ReadLine());

            Arithmetic obj = new Arithmetic(value1, value2);

            Del[] dobj = new Del[4];

            dobj[0] = new Del(obj.Add);
            int AddRet = dobj[0](value1,value2);
            Console.WriteLine("Addition is:{0}", AddRet);

            dobj[1] = new Del(obj.Sub);
            int SubRet = dobj[1](value1, value2);
            Console.WriteLine("Substraction is:{0}", SubRet);

            dobj[2] = new Del(obj.Mul);
            int MulRet = dobj[2](value1, value2);
            Console.WriteLine("Multiplication is:{0}", MulRet);

            dobj[3] = new Del(obj.Div);
            int DivRet = dobj[3](value1, value2);
            Console.WriteLine("Division is:{0}", DivRet);
        }
    }

    class Arithmetic
    {
        public int No1;
        public int No2;

        public Arithmetic(int x, int y)
        {
            No1 = x;
            No2 = y;
        }

        public int Add(int No1, int No2)
        {
            return No1 + No2;
        }

        public int Sub(int No1, int No2)
        {
            return No1 - No2;
        }

        public int Mul(int No1, int No2)
        {
            return No1 * No2;
        }

        public int Div(int No1, int No2)
        {
            if (No2 <= 0)
            {
                return -1;
            }

            return No1 / No2;
        }
    }
}
