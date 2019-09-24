using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Problem_Statement_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadSleep tobj = new ThreadSleep();

            Thread t8 = new Thread(new ThreadStart(tobj.Display));

            t8.Name = "Marvellous Eighth";

            t8.Start();

            t8.Join();

            Console.WriteLine("Continue from main Thread..");
        }
    }

    public class ThreadSleep
    {
        public void Display()
        {
            Thread t = Thread.CurrentThread;

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(t.Name + " is running ");

                Console.WriteLine(i);

                Thread.Sleep(1000);
            }
        }
    }
}
