using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Problem_Statement_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size:");
            int value = Convert.ToInt16(Console.ReadLine());

            Marvellous mobj = new Marvellous(value);

            mobj.Accept();

            Thread t1 = new Thread(new ThreadStart(mobj.EvenDisplay));

            Thread t2 = new Thread(new ThreadStart(mobj.OddDisplay));

            t1.Start();

            t2.Start();
        }
    }

    public class Marvellous
    {
        public int[] Arr;

        public Marvellous(int No)
        {
            Arr = new int[No];
        }

        public void Accept()
        {
            Console.WriteLine("Enter Data into Array:");
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = Convert.ToInt16(Console.ReadLine());
            }

            //Thread.Sleep(1500);
        }

        public void EvenDisplay()
        {
            Console.WriteLine("Even Numbers are:");
            for (int i = 0; i < Arr.Length; i++)
            {
                if ((Arr[i] % 2) == 0)
                {
                    Console.Write("{0}\t",Arr[i]);
                }
            }
            Console.WriteLine();

            //Thread.Sleep(1500);
        }

        public void OddDisplay()
        {
            Console.WriteLine("Odd Numbers are:");
            for (int i = 0; i < Arr.Length; i++)
            {
                if ((Arr[i] % 2) != 0)
                {
                    Console.Write("{0}\t", Arr[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
