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
            int i1 = 11, i2 = 21;

            float f1 = 3.14f, f2 = 6.14f;

            char c1 = 'a', c2 = 'b';

            double d1 = 8.0, d2 = 9.0;

            Marvellous mobj = new Marvellous();

            Console.WriteLine("Before Swap Integers:{0} & {1}", i1, i2);
            mobj.Swap(ref i1, ref i2);
            Console.WriteLine("After Swap Integers:{0} & {1}", i1, i2);
            Console.WriteLine();

            Console.WriteLine("Before Swap Floats:{0} & {1}", f1, f2);
            mobj.Swap(ref f1, ref f2);
            Console.WriteLine("After Swap Floats:{0} & {1}", f1, f2);
            Console.WriteLine();

            Console.WriteLine("Before Swap Characters:{0} & {1}", c1, c2);
            mobj.Swap(ref c1, ref c2);
            Console.WriteLine("After Swap Characters:{0} & {1}", c1, c2);
            Console.WriteLine();

            Console.WriteLine("Before Swap Doubles:{0} & {1}", d1, d2);
            mobj.Swap(ref d1, ref d2);
            Console.WriteLine("After Swap Doubles:{0} & {1}", d1, d2);
        }
    }

    public class Marvellous
    {
        public void Swap<T>(ref T No1, ref T No2)
        {
            T temp;

            temp = No1;
            No1 = No2;
            No2 = temp;
        }    
    }
}
