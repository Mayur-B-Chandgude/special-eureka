using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int Del(int No1,int No2);

namespace Problem_Statement_3
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

            Del DelObj = new Del(obj.Add);

            DelObj += new Del(obj.Sub);

            DelObj += new Del(obj.Mul);

            DelObj += new Del(obj.Div);

            Console.WriteLine("Division is:{0}", DelObj(value1, value2));
            DelObj -= new Del(obj.Div);

            Console.WriteLine("Multiplication is:{0}", DelObj(value1, value2));
            DelObj -= new Del(obj.Mul);

            Console.WriteLine("Substraction is:{0}", DelObj(value1, value2));
            DelObj -= new Del(obj.Sub);

            Console.WriteLine("Addition is:{0}", DelObj(value1, value2));
            DelObj -= new Del(obj.Add);
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
