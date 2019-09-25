using System;

namespace Assignment_Number_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////
            Number obj1 = new Number();
            obj1.Accept();
            obj1.Display();

            Console.Write("Enter Size of Array:");
            int size = Convert.ToInt16(Console.ReadLine());

            Number obj2 = new Number(size);
            obj2.Accept();
            obj2.Display();

            Number obj3 = new Number(obj2);
            ///////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////
            ArrayOperations ArrayOps1 = new ArrayOperations();
            ArrayOps1.Accept();
            int MaxRet = ArrayOps1.Maximum();
            Console.WriteLine("Maximum Number is:{0}", MaxRet);

            ArrayOperations ArrayOps2 = new ArrayOperations();
            ArrayOps2.Accept();
            int MinRet = ArrayOps2.Minimum();
            Console.WriteLine("Minimum Number is:{0}", MinRet);
            /////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////
            ArrayCombine ArrayCom = new ArrayCombine();

            ArrayCom.Accept();
            Console.Write("Enter Number to Search:");
            int value = Convert.ToInt16(Console.ReadLine());
            int SearchRet = ArrayCom.Search(value);
            if (SearchRet == -1)
            {
                Console.WriteLine("Number not Found..");
            }
            else
            {
                Console.WriteLine("number Found at location:{0}", SearchRet);
            }

            ArrayCombine ArrayCom1 = new ArrayCombine();
            ArrayCom1.Accept();
            Console.Write("Enter Number to Search:");
            int value1 = Convert.ToInt16(Console.ReadLine());
            int FrequencyCount = ArrayCom1.Frequency(value1);
            Console.WriteLine("Number`s Frequency is:{0}", FrequencyCount);

            ArrayCombine ArrayCom2 = new ArrayCombine();
            ArrayCom2.Accept();
            int SummationRet = ArrayCom2.Summation();
            Console.WriteLine("Array of Summation is:{0}", SummationRet);

            ArrayCombine ArrayCom3 = new ArrayCombine();
            ArrayCom3.Accept();
            int AvgRet = ArrayCom3.Average();
            Console.WriteLine("Average of Array is:{0}", AvgRet);
            /////////////////////////////////////////////////////////////////////////
        }
    }

    class Number
    {
       public int isize;
       public int[] Arr;

        public Number()
        {
            Console.Write("Enter Size of Array:");
            isize = Convert.ToInt16(Console.ReadLine());
            Arr = new int[this.isize];
        }

        public Number(int x)
        {
            this.isize = x;
            Arr = new int[this.isize];
        }

        public Number(Number obj)
        {
            //isize = obj.isize;
            Arr = new int[obj.isize];
           // obj.Accept();
            obj.Display();
        }

        public void Accept()
        {
            Console.WriteLine("Enter data:");
            for (int i = 0; i < isize; i++)
            {
                Arr[i] = Convert.ToInt16(Console.ReadLine());
            }
        }

        public void Display()
        {
            Console.WriteLine("Array Elements are:");
            for (int i = 0; i < isize; i++)
            {
                Console.Write("{0}\t", Arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    class ArrayOperations : Number
    {
        public int Maximum()
        {
            int MaxNumber = Arr[0];

            for (int i = 0; i < isize; i++)
            {
                if (Arr[i] > MaxNumber)
                {
                    MaxNumber = Arr[i];
                }
            }
            return MaxNumber;
        }

        public int Minimum()
        {
            int MinNumber = Arr[0];

            for (int i = 0; i < isize; i++)
            {
                if (Arr[i] < MinNumber)
                {
                    MinNumber = Arr[i];
                }
            }
            return MinNumber;
        }
    }

    class ArrayCombine : Number
    {
        public int Search(int No)
        {
            int i;

            for (i = 0; i < isize; i++)
            {
                if (Arr[i] == No)
                {
                    break;
                }
            }

            if (i == isize)
            {
                return -1;
            }
            else
            {
                return i + 1;
            }
        }

        public int Frequency(int No)
        {
            int cnt = 0;
            int i;

            for (i = 0; i < isize; i++)
            {
                if (Arr[i] == No)
                {
                    cnt++;
                }
            }
            return cnt;
        }

        public int Summation()
        {
            int sum = 0;

            for (int i = 0; i < isize; i++)
            {
                sum = sum + Arr[i];
            }
            return sum;
        }

        public int Average()
        {
            int avg = 0;
            int sum = 0;

            for (int i = 0; i < isize; i++)
            {
                sum = sum + Arr[i];
            }

            avg = sum / Arr.Length;

            return avg;
        }
    }
}
