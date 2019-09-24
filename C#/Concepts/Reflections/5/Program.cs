using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(string);

            Console.WriteLine("EventInfo of {0} type..", t);

            EventInfo[] EI = t.GetEvents(BindingFlags.Public | BindingFlags.NonPublic);

            foreach (EventInfo e in EI)
            {
                Console.WriteLine(e);
            }
        }
    }
}
