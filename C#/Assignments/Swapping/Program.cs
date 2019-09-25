using System;

namespace Swapping
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            Console.Write("Enter First Number:");
            int value1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            int value2 = Convert.ToInt32(Console.ReadLine());

            Swap obj = new Swap();

            obj.SwapA(&value1, &value2);
            obj.SwapR(ref value1, ref value2);
        }
    }

    class Swap
    {
        public unsafe void SwapA(int *p , int *q)
        {
            int temp;

            Console.WriteLine("Before Swapp:{0} {1}",*p,*q);
            temp = *p;
            *p = *q;
            *q = temp;
            Console.WriteLine("After Swapp:{0} {1}", *p, *q);
        }

        public void SwapR(ref int p , ref int q)
        {
            int temp;

            Console.WriteLine("Before Swapp:{0} {1}",p,q);
            temp = p;
            p = q;
            q = temp;
            Console.WriteLine("After Swapp:{0} {1}",p,q);
        }
    }
}
