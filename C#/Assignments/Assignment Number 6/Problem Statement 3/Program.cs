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
            Console.WriteLine("Enter Size:");
            int size = Convert.ToInt16(Console.ReadLine());

            MarvellousNew mobj = new MarvellousNew(size);

            mobj.Accept();

            Thread t1 = new Thread(new ThreadStart(mobj.Max));

            Thread t2 = new Thread(new ThreadStart(mobj.Min));

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

        
    }

    public class MarvellousNew : Marvellous
    {
        public MarvellousNew(int No) : base(No)
        {
 
        }

        public void Max()
        {
            int maxx = int.MinValue;

            foreach (int i in Arr)
            {
                if (maxx < i)
                {
                    maxx = i;
                }
            }
            Console.WriteLine("Maximum Number is:{0}", maxx);
}

        public void Min()
        {
            int minn = int.MaxValue;

            foreach (int i in Arr)
            {
                if (minn > i)
                {
                    minn = i;
                }
            }

            Console.WriteLine("Minimum Number is:{0}", minn);
        }
    }
}
