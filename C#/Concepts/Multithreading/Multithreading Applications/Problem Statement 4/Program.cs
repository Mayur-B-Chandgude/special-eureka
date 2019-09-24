using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Problem_Statement_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadSleep tobj = new ThreadSleep();

            Thread t7 = new Thread(new ThreadStart(tobj.Display));

            t7.Name = "Marvellous Seventh";

            t7.Start();

            try
            {
                t7.Abort();
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine(tobj.ToString());
            }
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
