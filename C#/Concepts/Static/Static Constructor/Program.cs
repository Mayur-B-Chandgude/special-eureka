using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo obj1 = new Demo();
            Demo obj2 = new Demo();
        }
    }

    class Demo
    {
        public static int i;

        public int j;

        public Demo()
        {
            Console.WriteLine("Inside Constructor..");
            i = 0;
            j = 0;
        }

        static Demo()
        {
            i = 0;

            //j = 0;
        }
    }
}
