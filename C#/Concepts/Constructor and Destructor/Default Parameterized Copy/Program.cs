using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_Parameterized_Copy
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo obj1 = new Demo();

            Console.Write("Enter Number:");
            int value = Convert.ToInt16(Console.ReadLine());

            Demo obj2 = new Demo(value);

            Demo obj3 = new Demo(obj2);
        }
    }

    class Demo
    {
        public int i;

        public Demo()
        {
            this.i = 11;
            Console.WriteLine("Inside Default Constructor..");
        }

        public Demo(int No)
        {
            this.i = No;
            Console.WriteLine("Inside Parametrized Constructor..");
        }

        public Demo(Demo obj)
        {
            this.i = obj.i;
            Console.WriteLine("Inside Copy Constructor..");
        }

        ~Demo()
        {
            Console.WriteLine("Inside Destructor..");
        }
    }
}
