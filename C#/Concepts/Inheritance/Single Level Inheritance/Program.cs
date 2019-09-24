using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Level_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Base bobj = new Base();

            Derived dobj = new Derived();

            bobj.fun();

            dobj.fun();
            dobj.gun();
        }
    }

    class Base
    {
        public int i;

        public void fun()
        {
            Console.WriteLine("Inside Base Fun..");
        }
    }

    class Derived : Base
    {
        public int j;

        public void gun()
        {
            Console.WriteLine("Inside Derived Gun..");
        }
    }
}
