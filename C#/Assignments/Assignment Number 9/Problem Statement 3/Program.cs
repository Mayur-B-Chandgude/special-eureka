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
            Console.WriteLine("Enter Starting Number:");
            int value1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Ending Number:");
            int value2 = Convert.ToInt16(Console.ReadLine());

            Marvellous mobj = new Marvellous();

            Thread t1 = new Thread(()=>mobj.DisplayF(value1,value2));

            Thread t2 = new Thread(()=>mobj.DisplayR(value1,value2));

            t1.Start();

            t1.Join();

            Console.WriteLine("Continue from Second Thread..");

            t2.Start();

           // t2.Join();
        }
    }

    public class Marvellous
    {
        public void DisplayF(int iStart ,int iEnd)
        {
            Console.WriteLine("Numbers in Forward Direction:");
            for (int i = iStart; i <= iEnd; i++)
            {
                Console.Write("{0}\t", i);
            }

            Thread.Sleep(1500);

            Console.WriteLine("\n");
        }

        public void DisplayR(int iStart , int iEnd)
        {
            Console.WriteLine("Numbers in Reverse Direction:");
            for (int i = iEnd; i >= iStart; i--)
            {
                Console.Write("{0}\t", i);
            }
            Console.WriteLine();
        }
    }
}
