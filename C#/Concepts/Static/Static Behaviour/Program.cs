using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Behaviour
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticDemo.gun();

            StaticDemo obj = new StaticDemo();

            obj.fun();
        }
    }

    class StaticDemo
    {
        public int i;
        public int j;

        public static int k;
        public static int m = 11;

        public void fun()
        {
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine(m);
        }

        public static void gun()
        {
           // Console.WriteLine(i);
           // Console.WriteLine(j);

            Console.WriteLine(k);
            Console.WriteLine(m);
        }

        public StaticDemo()
        {
            i = 21;
            j = 51;
        }
    }
}
