using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Statement_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();

            obj.fun(10, 0);
        }
    }

    class Demo
    {
        public void fun(int No1 , int No2)
        {
            int ans = No1 / No2;

            Console.WriteLine("Code Successfully Executed..");
        }
    }
}
