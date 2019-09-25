using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Statement_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            int num = Convert.ToInt16(Console.ReadLine());

            Number NumObj = new Number(num);

            Boolean ArmRet = NumObj.ChkArmstrong();
            if (ArmRet == true)
            {
                Console.WriteLine("Number is Armstrong Number..");
            }
            else
            {
                Console.WriteLine("Number is Not Armstrong Number..");
            }

            Boolean StrongRet = NumObj.ChkStrong();
            if (StrongRet == true)
            {
                Console.WriteLine("Number is Strong Number..");
            }
            else
            {
                Console.WriteLine("Number is not Strong Number..");
            }

           int CountRet = NumObj.CountDigit(num);
           Console.WriteLine("Count is:{0}", CountRet);

           int SumRet = NumObj.SumFactor(num);
           Console.WriteLine("Sum of Factor is:{0}", SumRet);

           Console.WriteLine("Enter Second Number:");
           int num2 = Convert.ToInt16(Console.ReadLine());
           int PowerRet = NumObj.Power(num,num2);
           Console.WriteLine("Power of Number is:{0}", PowerRet);
        }
    }

    abstract class Marvellous
    {
        public int No;

        public Marvellous(int x)
        {
            No = x;
        }

        public int Power(int x, int y)
        {
            int PowerNumber = 1;

            for (int i = 0; i < y; i++)
            {
                PowerNumber = PowerNumber * x;
            }

            return PowerNumber;
        }

        public int SumFactor(int No)
        {
            int sum = 0;

            for (int i = 1; i < No / 2; i++)
            {
                if ((No % i) == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public int CountDigit(int No)
        {
            int digit, cnt = 0;

            while (No != 0)
            {
                digit = No % 10;
                cnt++;
                No = No / 10;
            }

            return cnt;
        }

        public abstract Boolean ChkStrong();
        public abstract Boolean ChkArmstrong();
    }

    class Number : Marvellous
    {
        public Number(int value) : base(value)
        {

        }

        public override Boolean ChkArmstrong()
        {
            int digit , sum = 0;
            int cnt = 1;
         
            int temp = No;

            while (No != 0)
            {
                digit = No % 10;
                while (digit != 0)
                {
                    cnt = cnt * digit;
                    digit--;
                }

                sum += cnt;
                cnt = 1;
                No = No / 10;
            }

            if (sum == temp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override Boolean ChkStrong()
        {
            int digit, cnt = 0;
            int sum = 0;
            int NumberPower = 1;
            int temp = No;

            while (temp != 0)
            {
                cnt++;
                No = No / 10;
            }

            temp = No;
            while (No != 0)
            {
                digit = No % 10;
                for (int i = 1; i <= cnt; i++)
                {
                    NumberPower = NumberPower * digit;
                }

                sum = sum + NumberPower;
                NumberPower = 1;
                No = No / 10;
            }

            if (sum == temp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
