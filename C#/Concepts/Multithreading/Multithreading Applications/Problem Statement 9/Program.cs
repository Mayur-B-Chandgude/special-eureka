using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Problem_Statement_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int ret = 0;

            Console.WriteLine("Enter Number:");
            int value = Convert.ToInt32(Console.ReadLine());

            SinglTask tobj = new SinglTask();

            Thread t17 = new Thread(() => { ret = tobj.Display(value); });

            t17.Start();

            t17.Join();

            Console.WriteLine("Digit Count is:{0}", ret);
        }
    }

    public class SinglTask
    {
        public int Display(int No)
        {
            int idigit = 0;
            int cnt = 0;

            while (No != 0)
            {
                idigit = No % 10;
                cnt++;
                No = No / 10;
            }

            return cnt;
        }
    }
}
