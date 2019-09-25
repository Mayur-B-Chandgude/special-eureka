using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Statement_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Size:");
            int size = Convert.ToInt32(Console.ReadLine());

            Marvellous<int> mobj = new Marvellous<int>(size);
            mobj.Accept();
            mobj.Display();
            mobj.BubbleSort();
            Console.WriteLine(mobj.BinarySearch(51));
            Console.WriteLine(mobj.LinearSearch(51));
            Console.WriteLine(mobj.LinearSearchBidirectional(21));

            Marvellous<char> charArray = new Marvellous<char>(size);
            charArray.Accept();
            charArray.Display();
            charArray.BubbleSort();
            Console.WriteLine(charArray.BinarySearch('M'));
            Console.WriteLine(charArray.LinearSearch('M'));
            Console.WriteLine(charArray.LinearSearchBidirectional('M'));
        }
    }

    public class Marvellous<T>
    {
        private T [] Arr;

        public Marvellous(int size)
        {
            Arr = new T[size + 1];
        }

        public void Accept()
        {
            Console.WriteLine("Enter Data:");
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            }
        }

        public void Display()
        {
            Console.WriteLine("Elements are:");
            foreach (dynamic d in Arr)
            {
                Console.WriteLine("\t" + d);
            }
        }

        public void BubbleSort()
        {
            for (int i = 0; i < Arr.Length-1; i++)
            {
                for (int j = 0; j < Arr.Length-i-1; j++)
                {
                    dynamic bubblesort = Arr[j];

                    if (bubblesort > Arr[j + 1])
                    { 
                        dynamic temp = Arr[j];
                        Arr[j] = Arr[j + 1];
                       Arr[j + 1] = temp;
                    }
                }
            }
        }

        public void BubbleSortEfficient()
        {
            bool swapped;

            for (int i = 0; i < Arr.Length - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < Arr.Length - i - 1; j++)
                {
                    dynamic EfficientBubble = Arr[j];

                    if (EfficientBubble > Arr[j + 1])
                    {
                        dynamic temp = EfficientBubble;
                        EfficientBubble = Arr[j + 1];
                        Arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;
            }
        }

        public void SelectionSort()
        {
            int n = Arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < n; j++)
                {
                    dynamic a = Arr[j];
                    if (a < Arr[min])
                        min = j;
                }

                dynamic temp = Arr[min];
                Arr[min] = Arr[i];
                Arr[i] = temp;
            }
        }

        public void InsertionSort()
        {
            for (int i = 1; i < Arr.Length; i++)
            {
                dynamic key = Arr[i];
                int j = i - 1;

                while (j >= 0 && Arr[j] > key)
                {
                    Arr[j + 1] = Arr[j];
                    j = j - 1;
                }
                Arr[j + 1] = key;
            }
        }

        public int LinearSearch(T No)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                dynamic linear = Arr[i];
                if (linear == No)
                    return i + 1;
            }
            return -1;
        }

        public int LinearSearchBidirectional(T No)
        {
            int cnt = 0;
            for (int i = 0; i <= Arr.Length / 2; i++)
            {
                dynamic linearBi = Arr[i];

                if (linearBi == No)
                {
                    cnt = i + 1;
                    break;
                }
                dynamic b = Arr[Arr.Length - 1 - i];
                if (b == No)
                {
                    cnt = Arr.Length - i;
                    break;
                }
            }

            if (cnt != 0)
            {
                return cnt;
            }
            else
            {
                return -1;
            }
        }


        public int BinarySearch(T No)
        {
            int min = 0;
            int max = Arr.Length - 1;
            dynamic key = No;

            while (min <= max)
            {
                int mid = (min + max) / 2;

                if (key == Arr[mid])
                {
                    return ++mid;
                }
                else if (key < Arr[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
