using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Statement_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Starting Number:");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Ending Number:");
            int num2 = Convert.ToInt16(Console.ReadLine());

            MyRange obj = new MyRange(num1,num2);

            Console.WriteLine("\n");
            int ret = obj.SumRange();
            Console.WriteLine("Sum is:{0}\n", ret);

            obj.DisplayEven();
            obj.DisplayOdd();
            obj.DisplayPerfect();
            obj.DisplayPrime();
        }
    }

    abstract class MarvellousRange
    {
        public int istart;
        public int iend;

        public MarvellousRange(int value1, int value2)
        {
            istart = value1;
            iend = value2;
        }

        public abstract int SumRange();
        public abstract void DisplayEven();
        public abstract void DisplayOdd();
        public abstract void DisplayPrime();
        public abstract void DisplayPerfect();
    }

    class MyRange : MarvellousRange
    {
        public MyRange(int No1, int No2)  : base(No1, No2)
        {
 
        }

        public override int SumRange()
        {
            int cnt = 0;

            for (int i = istart; i <= iend; i++)
            {
                cnt = cnt + i;
            }

            return cnt;
        }

        public override void DisplayEven()
        {
            Console.WriteLine("Even Numbers are:");
            for (int i = istart; i <= iend; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.Write("{0}\t", i); 
                }
            }
            Console.WriteLine("\n");
        }

        public override void DisplayOdd()
        {
            Console.WriteLine("Odd Numbers are:");
            for (int i = istart; i <= iend; i++)
            {
                if ((i % 2) != 0)
                {
                    Console.Write("{0}\t", i);
                }
            }
            Console.WriteLine("\n");
        }

        public override void DisplayPrime()
        {
            int cnt = 0;
            int i = 0;

            Console.WriteLine("Prime Numbers are:");
            for (i = istart; i < iend; i++)
            {
                cnt = 0;
                if(i>1)
                {
                    for (int j = 2; j < i; j++)
                    {
                         if ((i % j) == 0)
                        {
                            cnt = 1;
                             break;
                        }
                    }
                    if (cnt == 0)
                    {
                        Console.Write("{0}\t", i);
                    }
                }
            }
            Console.WriteLine("\n");
        }

        public override void DisplayPerfect()
        {
            int cnt = 0;
            int sum = 0;

            Console.WriteLine("Perfect Numbers are:");
            for (int i = istart; i <= iend; i++)
            {
                sum = 0;

                for (cnt = 1; cnt < i; cnt++)
                {
                    if ((i % cnt) == 0)
                    {
                        sum = sum + cnt;
                    }
                }

                if (sum == i)
                {
                    Console.Write("{0}\t", i);
                }
            }
            Console.WriteLine("\n");
        }
    } 
}
