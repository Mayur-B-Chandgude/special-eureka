using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library;

namespace Implict_Linking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside Implict linking main class..");

            Class1 obj = new Class1();

            obj.fun();
        }
    }
}
