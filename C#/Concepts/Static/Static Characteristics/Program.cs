using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Charactristics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Static Charactristics before object:{0}", StaticDemo.k);

            StaticDemo obj = new StaticDemo();

           // Console.WriteLine("Static Charateristics:{0}", obj.k);

            Console.WriteLine("Static Characteristics after object:{0}", StaticDemo.m);
        }
    }

    class StaticDemo
    {
        public int i;
        public int j;

        public static int k;
        public static int m = 11;

        public StaticDemo()
        {
            i = 21;
            j = 51;
        }
    }
}
