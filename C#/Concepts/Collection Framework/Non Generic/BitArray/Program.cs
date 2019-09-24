using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Statement_1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] a = { 10 };
            byte[] b = { 64 };
            byte[] c = { 25 };

            BitArray ba1 = new BitArray(8);
            BitArray ba2 = new BitArray(8);
            BitArray ba3 = new BitArray(8);

            ba1 = new BitArray(a);
            ba2 = new BitArray(b);
            ba3 = new BitArray(c);

            Console.WriteLine("First BitArray whose value is 10");
            for (int i = 0; i < ba1.Count; i++)
            {
                Console.Write("{0 , -6}", ba1[i]);
            }
            Console.WriteLine();

            Console.WriteLine("First BitArray whose value is 25");
            for (int i = 0; i < ba2.Count; i++)
            {
                Console.Write("{0 , -6}", ba2[i]);
            }
            Console.WriteLine();

            Console.WriteLine("First BitArray whose value is 64");
            for (int i = 0; i < ba3.Count; i++)
            {
                Console.Write("{0 , -6}", ba3[i]);
            }
            Console.WriteLine();

            Console.WriteLine("BitArray ba2: 13");
            for (int i = 0; i < ba2.Count; i++)
            {
                Console.Write("{0 , -6}", ba1[i]);
            }
            Console.WriteLine();

            BitArray ba4 = new BitArray(8);

            ba4 = ba1.And(ba2);
            Console.WriteLine("After AND operation:");
            for (int i = 0; i < ba4.Count; i++)
            {
                Console.Write("{0 , -6}", ba4[i]);
            }
            Console.WriteLine();

            ba4.Set(3, true);
            Console.WriteLine("After SET operation:");
            for (int i = 0; i < ba4.Count; i++)
            {
                Console.Write("{0 , -6}", ba4[i]);
            }
            Console.WriteLine();

            ba4 = ba1.Or(ba2);
            Console.WriteLine("After OR operation:");
            for (int i = 0; i < ba4.Count; i++)
            {
                Console.Write("{0 , -6}", ba4[i]);
            }
            Console.WriteLine();

            ba4 = ba1.Xor(ba2);
            Console.WriteLine("After XOR operation:");
            for (int i = 0; i < ba4.Count; i++)
            {
                Console.Write("{0 , -6}", ba4[i]);
            }
            Console.WriteLine();
        }
    }
}
