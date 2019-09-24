
//Multithreaded application with Non Static Thread procedure.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Problem_Statement_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleTask2 s1 = new SingleTask2();

            Thread t3 = new Thread(new ThreadStart(s1.fun));

            Thread t4 = new Thread(new ThreadStart(s1.fun));

            t3.Name = "Marvellous Fourth";

            t4.Name = "Marvellous Fifth";

            t3.Start();

            t4.Start();
        }
    }

    public class SingleTask2
    {
        public void fun()
        {
            Thread t = Thread.CurrentThread;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(t.Name + " is running ");

                Console.WriteLine(i);
            }
        }
    }
}
