using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Nunmber:");
            int num = Convert.ToInt32(Console.ReadLine());

            Factorial obj = new Factorial();

            int ret = obj.Ops(num);
            Console.WriteLine("Factorial is:{0}", ret);
        }
    }

    class Factorial
    {
        public int Ops(int No)
        {
            if (No <= 0)
            {
                return -1;
            }

            int fact = 1;

            for (int i = 1; i <= No; i++)
            {
                fact = fact * i;
            }

            return fact;
        }
    }
}
