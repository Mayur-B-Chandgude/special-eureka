using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Problem_Statement_1
{
    public class Marvellous
    {
        public void DisplayRange(int iStart , int iEnd)
        {
            Console.WriteLine("Numbers are:");
            for (int i = iStart; i <= iEnd; i++)
            {
                Console.Write("{0}\t", i);
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Starting Range:");
            int value1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Ending Range:");
            int value2 = Convert.ToInt16(Console.ReadLine());

            Marvellous mobj = new Marvellous();

            Thread t1 = new Thread(() => mobj.DisplayRange(value1, value2));

            // Thread t2 = new Thread(new ThreadStart(mobj.DisplayRange(value1,value2)));

            t1.Start();
        }
    }
}