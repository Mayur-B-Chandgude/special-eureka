using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int fptr(int No1, int No2);

namespace Problem_Statement_1
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

            fptr obj1 = new fptr(obj.Add);
            Console.WriteLine("Addition is:{0}", obj1(value1, value2));

            fptr obj2 = new fptr(obj.Sub);
            Console.WriteLine("Substraction is:{0}", obj2(value1, value2));

            fptr obj3 = new fptr(obj.Mul);
            Console.WriteLine("Multiplication is:{0}", obj.Mul(value1, value2));

            fptr obj4 = new fptr(obj.Dev);
            Console.WriteLine("Division is:{0}", obj4(value1, value2));
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

        public int Dev(int No1, int No2)
        {
            if (No2 <= 0)
            {
                return -1;
            }

            return No1 / No2;
        }
    }
}
