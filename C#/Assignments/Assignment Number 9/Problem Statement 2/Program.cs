using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Problem_Statement_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Marvellous mobj = new Marvellous();

            Thread t1 = new Thread(new ThreadStart(mobj.Display));

            t1.Start();
        }
    }

    public class Marvellous
    {
        public void Display()
        {
            Thread t = Thread.CurrentThread;

            t.Name = "Marvellous";

            Console.WriteLine("Thread Name is:{0}",t.Name);
            Console.WriteLine("Thread Priority is:{0}",t.Priority);
            Console.WriteLine("Thread ID is:{0}",t.ManagedThreadId);

            if (t.IsAlive)
            {
                Console.WriteLine("Thread is Alive.");
            }

            Console.WriteLine("Thread State is:{0}",t.ThreadState);
        }
    }
}
