using System;

namespace Maximum_and_Minimum_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers obj = new Numbers(11 , 21 , 51);

            int ret1 = obj.Max();
            Console.WriteLine("Max Number is:{0}",ret1);

            int ret2 = obj.Min();
            Console.WriteLine("Min Number is:{0}",ret2);
        }
    }

    class Numbers
    {
        int No1;
        int No2;
        int No3;

        public Numbers(int x , int y , int z)
        {
            No1 = x;
            No2 = y;
            No3 = z;
        }

        public int Max()
        {
            if((No1 >= No2) && (No1 >= No3))
            {
                return No1;
            }
            else if((No2 >= No1) && (No2 >= No3))
            {
                return No2;
            }
            else
            {
                return No3;
            }
        }

        public int Min()
        {
            if((No1 <= No2) && (No1 <= No3))
            {
                return No1;
            }
            else if((No2 <= No1) && (No2 <= No3))
            {
                return No2;
            }
            else
            {
                return No3;
            }
        }
    }
}
