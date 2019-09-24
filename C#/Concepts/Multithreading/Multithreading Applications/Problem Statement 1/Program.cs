

//Multithreaded application with Static Thread procedure.

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
            Console.WriteLine("Multiple thread as a static method performing same task..");

            Thread t1 = new Thread(new ThreadStart(SingleTask1.DisplayF));
            Thread t2 = new Thread(new ThreadStart(SingleTask1.DisplayF));

            t1.Name = "Marvellous First";
            t2.Name = "Marvellous Second";

            t1.Start();
            t2.Start();
        }
    }

    public class SingleTask1
    {
        public static void DisplayF()
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
