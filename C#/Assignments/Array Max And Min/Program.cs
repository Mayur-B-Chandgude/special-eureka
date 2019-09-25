using System;

namespace ArrayMaxAndMin
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            Console.Write("Enter Number of Elements:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[size];

            Console.WriteLine("Array Elements:");
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            MaxMin obj = new MaxMin();

            int ret1 = obj.Max(Arr);
            Console.WriteLine("Max Number is:{0}", ret1);

            int ret2 = obj.Min(Arr);
            Console.WriteLine("Min Number is:{0}", ret2);
        }
    }

    class MaxMin
    {
        public unsafe int Max(int[] Arr)
        {
            int max = 0;

            max = Arr[0];

            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] > max)
                {
                    max = Arr[i];
                }
            }
            return max;
        }

        public unsafe int Min(int[] Arr)
        {
            int min = 0;

            min = Arr[0];

            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] < min)
                {
                    min = Arr[i];
                }
            }
            return min;
        }
    }
}
