using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_and_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo obj = new Demo();

            //Derived obj1 = new Derived();

            //obj1.fun();

            Console.WriteLine("value of static members:{0}", Hello.i);

            Hello nobj1 = new Hello();
            Hello nobj2 = new Hello();
        }
    }

    class Demo
    {
        public static int i = 10;

        private Demo()
        {
            Console.WriteLine("Inside Private Constructor..");
        }

        public void fun()
        {
            Console.WriteLine("Inside Demo fun..");
        }
    }
    /*
    class Derived : Demo
    {
        public void fun()
        {
            Console.WriteLine("Inside Derived Fun..");
        }
    }
    */
    class Hello
    {
        public static int i;

        static Hello()
        {
            i = 21;
            Console.WriteLine("Inside Static Constructor..");
        }
    }
}
