using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Statement_Checked_Unchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            //Marvellous.Demo(int.MaxValue);

            //Marvellous.CheckedDemo(int.MaxValue);

            Marvellous.UncheckedDemo(int.MaxValue);
        }
    }

    class Marvellous
    {
        public static void Demo(int No)
        {
           Console.WriteLine("Demo:" + (No + 10));
        }

        public static void CheckedDemo(int No)
        {
            checked
            {
                Console.WriteLine("Checked:" + (No + 10));
            }
        }

        public static void UncheckedDemo(int No)
        {
            unchecked
            {
                Console.WriteLine("Unchecked:" + (No + 10));
            }
        }
    }
}
