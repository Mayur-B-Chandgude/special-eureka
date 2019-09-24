using System;

namespace AdditionOfArray
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Elements:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[size];

            Console.WriteLine("Enter Elements in Array:");
            for (int i = 0; i < size; i++)
            {
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Addition obj = new Addition();

            int ret = obj.Add(Arr , size);
            Console.WriteLine("Addition is:{0}", ret);
        }
    }

    class Addition
    {
        public unsafe int Add(int [] Arr , int size)
        {
            int sum = 0;

            for(int i = 0 ; i < size ; i++)
            {
                sum = sum + Arr[i];
            }
            return sum;
        }
    }
}
