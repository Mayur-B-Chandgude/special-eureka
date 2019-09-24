using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Problem_Statement_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Marvellous mobj = new Marvellous();

            Thread t1 = new Thread(new ThreadStart(mobj.fun));

            t1.Name = "Thread Marvellous..";

            t1.Start();

            t1.Join();

            Console.WriteLine("Main Thread is running..");
        }
    }

    public class Marvellous
    {
        public void fun()
        {
            Thread t = Thread.CurrentThread;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(t.Name + "is running");

                Console.WriteLine(i);
            }

            if (t.IsAlive)
            {
                Console.WriteLine("Thread is Alive..");
            }

            Console.WriteLine("Thread Priority of current Thread is:{0}", t.Priority);

            Console.WriteLine("Thread State of Current Thread:{0}", t.ThreadState);

            Console.WriteLine("Thread ID of current Thread is:{0}", t.ManagedThreadId);

            if (t.IsBackground)
            {
                Console.WriteLine("Thread is in Background..");
            }
        }
    }
}
