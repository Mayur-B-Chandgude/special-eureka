using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Level_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Base bobj = new Base();
            Derived dobj = new Derived();
            MyDerived mobj = new MyDerived();

            bobj.fun();

            dobj.fun();
            dobj.gun();

            mobj.fun();
            mobj.gun();
            mobj.sun();
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

    class MyDerived : Derived
    {
        public int k;

        public void sun()
        {
            Console.WriteLine("Inside MyDerived Sun..");
        }
    }
}
