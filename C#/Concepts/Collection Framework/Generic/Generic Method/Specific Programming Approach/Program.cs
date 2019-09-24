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
            mobj.SwapInt(ref i1, ref i2);
            Console.WriteLine("After Swap Integers:{0} & {1}", i1, i2);

            Console.WriteLine("Before Swap Floats:{0} & {1}", f1, f2);
            mobj.SwapFloat(ref f1, ref f2);
            Console.WriteLine("After Swap Floats:{0} & {1}", f1, f2);

            Console.WriteLine("Before Swap Characters:{0} & {1}", c1, c2);
            mobj.SwapChar(ref c1, ref c2);
            Console.WriteLine("After Swap Characters:{0} & {1}", c1, c2);

            Console.WriteLine("Before Swap Doubles:{0} & {1}", d1, d2);
            mobj.SwapDouble(ref d1, ref d2);
            Console.WriteLine("After Swap Doubles:{0} & {1}", d1, d2);
        }
    }

    public class Marvellous
    {
        public void SwapInt(ref int No1, ref int No2)
        {
            int temp;

            temp = No1;
            No1 = No2;
            No2 = temp;
        }

        public void SwapFloat(ref float No1, ref float No2)
        {
            float temp;

            temp = No1;
            No1 = No2;
            No2 = temp;
        }

        public void SwapChar(ref char No1, ref char No2)
        {
            char temp;

            temp = No1;
            No1 = No2;
            No2 = temp;
        }

        public void SwapDouble(ref double No1, ref double No2)
        {
            double temp;

            temp = No1;
            No1 = No2;
            No2 = temp;
        }
    }
}
