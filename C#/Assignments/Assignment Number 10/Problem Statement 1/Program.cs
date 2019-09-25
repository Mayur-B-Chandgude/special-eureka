using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Problem_Statement_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Marvellous mobj = new Marvellous();

            mobj.fun();

            mobj.gun();
        }
    }

    class Marvellous
    {
        //TimeSpan ts = stopWatch.Elapsed;

        public void fun()
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            for (int i = 0; i < 2000; i++)
            {
                Console.Write("{0}\t", i);
                //Thread.Sleep(10);
            }
            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds,ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        public void gun()
        {
            Stopwatch stopWatch = new Stopwatch(); 

            stopWatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("{0}\t", i);
                //Thread.Sleep(10);
            }
            stopWatch.Stop();

            Console.WriteLine("Time elapsed:{0}", stopWatch.Elapsed);
        }
    }
}
