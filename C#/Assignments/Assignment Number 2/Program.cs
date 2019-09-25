using System;

namespace Assignment_Number_4
{
    class Program
    {
        static void Main(string[] args)
        {
            NumOperation Numobj = new NumOperation();

            Console.Write("Enter Number:");
            int value = Convert.ToInt16(Console.ReadLine());
            NumOperation Numobj1 = new NumOperation(value);

            NumOperation numobj2 = new NumOperation();
            numobj2.Accept();

            bool bret = Numobj1.ChkEven();
            if (bret == true)
            {
                Console.WriteLine("Number is Even..");
            }
            else
            {
                Console.WriteLine("Number is not even..");
            }

            Numobj.DisplayFactors();

            int ret = Numobj1.SumFactors();
            Console.WriteLine("Sum of Factor is:{0}", ret);

            NumActivity numactivityobj = new NumActivity();

            bool primeret = numactivityobj.ChkPrime();
            if (primeret == true)
            {
                Console.WriteLine("Number is Prime..");
            }
            else
            {
                Console.WriteLine("Number not Prime..");
            }

            bool perfectret = numactivityobj.ChkPerfect();
            if (perfectret == true)
            {
                Console.WriteLine("Number is Perfect..");
            }
            else
            {
                Console.WriteLine("Number not Perfect..");
            }

            int factret = numactivityobj.Factorial();
            Console.WriteLine("Factorial is:{0}", factret);
        }
    }

    abstract class NumTemplate
    {
        public int No;

        public NumTemplate()
        {
            Console.Write("Enter Number:");
            No = Convert.ToInt16(Console.ReadLine());
        }

        public NumTemplate(int value)
        {
            No = value;
        }

        public abstract void Accept();
        public abstract void Display();
        public abstract bool ChkEven();
        public abstract void DisplayFactors();
        public abstract int SumFactors();
    }

    class NumOperation : NumTemplate
    {
        int num;

        public NumOperation(int x)
        {
            this.num = x;
        }

        public NumOperation()
        {
 
        }

        public override void Accept()
        {
            Console.Write("Enter Number:");
            this.num = Convert.ToInt16(Console.ReadLine());
        }

        public override bool ChkEven()
        {
            if ((No % 2) == 0)
            {
                return true;
            }
            return false;
        }

        public override void DisplayFactors()
        {
            for (int i = 1; i <= No / 2; i++)
            {
                if ((No % i) == 0)
                {
                    Console.Write("{0}\t", i);
                }
            }
            Console.WriteLine();
        }

        public override int SumFactors()
        {
            int sum = 0;

            for (int i = 1; i <= No / 2; i++)
            {
                if ((No % i) == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }

        public override void Display()
        {
            
        } 
    }

    class NumActivity : NumOperation
    {
        public bool ChkPrime()
        {
            if ((No % 2) == 0)
            {
                return true;
            }
            return false;
        }

        public bool ChkPerfect()
        {
            int sum = 0;
            int cnt = No;

            for (int i = 1; i <= No / 2; i++)
            {
                if ((No % i) == 0)
                {
                    sum = sum + i;
                }
            }

            if (cnt == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Factorial()
        {
            int fact = 1;

            for (int i = 1; i <= No; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
