using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(string);

            Console.WriteLine("Fields of {0} type..", t);

            FieldInfo[] FI = t.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

            foreach (FieldInfo f in FI)
            {
                Console.WriteLine(f);
            }
        }
    }
}
