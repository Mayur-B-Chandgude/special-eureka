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
            Console.WriteLine("Enter Number:");
            int value = Convert.ToInt16(Console.ReadLine());

            Marvellous mobj = new Marvellous(value);

            Thread t1 = new Thread(new ThreadStart(mobj.ChkPrime));

            Thread t2 = new Thread(new ThreadStart(mobj.ChkPerfect)); 

            t1.Start();

            t2.Start();
        }
    }

    public class Marvellous
    {
        public int iNo;

        public Marvellous(int x)
        {
            iNo = x;
        }

        public void ChkPrime()
        {
            int cnt = 0;

            for (int i = 1; i <= iNo; i++)
            {
                if ((iNo % i) == 0)
                {
                    cnt++;
                }
            }

            if (cnt == 2)
            {
                Console.WriteLine("Number is Prime Number..");
            }
            else
            {
                Console.WriteLine("Number is not Prime Number..");
            }
        }

        public void ChkPerfect()
        {
            int add = 0;
            int temp = iNo;

            for (int i = 1; i < iNo; i++)
            {
                if ((iNo % i) == 0)
                {
                    add = add + i;
                }
            }

            if (add == temp)
            {
                Console.WriteLine("Number is Perfect..");
            }
            else
            {
                Console.WriteLine("Number is not Perfect..");
            }

        }
    }
}
