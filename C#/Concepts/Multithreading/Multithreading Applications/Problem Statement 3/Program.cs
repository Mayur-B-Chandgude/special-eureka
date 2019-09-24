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
            MultipleTask mobj = new MultipleTask();

            Thread t5 = new Thread(new ThreadStart(mobj.DisplayF));

            Thread t6 = new Thread(new ThreadStart(mobj.DisplayB));

            t5.Name = "Marvellous Fifth";

            t6.Name = "Marvellous Sixth";

            t5.Start();

            t6.Start();
        }
    }

    public class MultipleTask
    {
        public void DisplayF()
        {
            Thread t = Thread.CurrentThread;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(t.Name + " is running ");

                Console.WriteLine(i);
            }
        }

        public void DisplayB()
        {
            Thread t = Thread.CurrentThread;

            for(int i = 0; i<10; i++)
            {
                Console.WriteLine(t.Name + " is running ");

                Console.WriteLine(i);
            }
        }
    }
}
