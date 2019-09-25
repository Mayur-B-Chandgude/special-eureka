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
            Console.WriteLine("Enter Size:");
            int size = Convert.ToInt32(Console.ReadLine());

            MarvellousArray<int> IntergerObject = new MarvellousArray<int>(size);

            IntergerObject.Accept();

            Console.WriteLine("Enter Number to Search:");
            int value1 = Convert.ToInt32(Console.ReadLine());

            int FrequencyRet = IntergerObject.Frequency(value1);
            Console.WriteLine("Frequency Of Number is:{0}", FrequencyRet);

            int FirstOccurranceRet = IntergerObject.FirstOccurrence(value1);
            Console.WriteLine("First Occurrance Index is:{0}", FirstOccurranceRet);

            int LastOccurranceRet = IntergerObject.LastOccurrence(value1);
            Console.WriteLine("Last Occurrance Index is:{0}", LastOccurranceRet);

            Console.WriteLine("Maximum Number is:{0}", IntergerObject.MaximumNumber());

            Console.WriteLine("Minimum Number is:{0}", IntergerObject.MinimumNumber());
        }
    }

    public class MarvellousArray<T>
    {
        private T[] Arr;

        object[] objectArray;

        public MarvellousArray(int size)
        {
            Arr = new T[size];
        }

        public void Accept()
        {
            Console.WriteLine("Enter Data:");
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = (T)Convert.ChangeType(Console.ReadLine(),typeof(T));
            }
        }
        public int Frequency(T No)
        {
            int FreqCnt = 0;

            for (int i = 0; i < Arr.Length; i++)
            {
                if (No.Equals(Arr[i]))
                {
                    FreqCnt++;
                }
            }
            return FreqCnt;
        }

        public int FirstOccurrence(T No)
        {
            int i = 0;

            for (i = 0; i < Arr.Length; i++)
            {
                if (No.Equals(Arr[i]))
                {
                    break;
                }
            }

            if (i.Equals(Arr.Length))
            {
                return -1;
            }
            else
            {
                return i + 1;
            }
        }

        public int LastOccurrence(T No)
        {
            int i = 0;

            for (i = Arr.Length-1; i >= 0; i--)
            {
                if (No.Equals(Arr[i]))
                {
                    break;
                }
            }

            if (i.Equals(-1))
            {
                return -1;
            }
            else
            {
                return i + 1;
            }
        }

       public T MaximumNumber()
        {
            dynamic max = Arr[0];

            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] > max)
                {
                    max = Arr[i];
                }
            }
            return max;
        }

        public T MinimumNumber()
        {
            dynamic min = Arr[0];

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
