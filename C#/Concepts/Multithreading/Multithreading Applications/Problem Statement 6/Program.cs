using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Problem_Statement_6
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadSleep tobj = new ThreadSleep();

            Thread t9 = new Thread(new ThreadStart(tobj.Display));

            Thread t10 = new Thread(new ThreadStart(tobj.Display));

            Thread t11 = new Thread(new ThreadStart(tobj.Display));

            Thread t12 = new Thread(new ThreadStart(tobj.Display));

            Thread t13 = new Thread(new ThreadStart(tobj.Display));

            t9.Name = "Marvellous Ninth";

            t10.Name = "Marvellous Tenth";

            t11.Name = "Marvellous Eleventh";

            t12.Name = "Marvellous Twelvth";

            t13.Name = "Marvellous Thirteen";

            t9.Priority = ThreadPriority.AboveNormal;

            t10.Priority = ThreadPriority.BelowNormal;

            t11.Priority = ThreadPriority.Highest;

            t12.Priority = ThreadPriority.Lowest;

            t13.Priority = ThreadPriority.Normal;

            t9.Start();

            t10.Start();

            t11.Start();

            t12.Start();

            t13.Start();
        }
    }

    public class ThreadSleep
    {
        public void Display()
        {
            Thread t = Thread.CurrentThread;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(t.Name + " is running ");

                Console.WriteLine(i);

                Thread.Sleep(1000);
            }
        }
    }
}
