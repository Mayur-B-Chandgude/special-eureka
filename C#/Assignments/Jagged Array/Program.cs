using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            Console.Write("Enter Number of rows:");
            int row = Convert.ToInt32(Console.ReadLine());

            int[][] Arr = new int[row][];

            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr[i].Length; j++)
                {
                    Arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Jagged obj = new Jagged();

            obj.array(Arr);
        }
    }

    class Jagged
    {
        public unsafe void array(int[][] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr[i].Length; j++)
                {
                    Console.WriteLine(Arr[i][j] + "");
                }
            }
        }
    }
}
