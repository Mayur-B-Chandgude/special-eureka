using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Problem_Statement_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            int value1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            int value2 = Convert.ToInt32(Console.ReadLine());

            SingleTask tobj = new SingleTask();

            Thread t16 = new Thread(() => tobj.Display(value1, value2));

            t16.Start();
        }
    }

    public class SingleTask
    {
        public void Display(int No1, int No2)
        {
            while (No1 != 0)
            {
                No2++;
                No1--;
            }

            Console.WriteLine("Addition without plus Operator:{0}", No2);
        }
    }
}
