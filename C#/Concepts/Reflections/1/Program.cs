using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t2 = typeof(Marvellous);
            Console.WriteLine(t2.Assembly + "\n");

            Type t1 = typeof(string);
            Console.WriteLine(t1.Assembly + "\n");
        }
    }

    class Marvellous
    {
        public int No1;
        public int No2;

        public void fun()
        {
            //logic
        }
    }
}
