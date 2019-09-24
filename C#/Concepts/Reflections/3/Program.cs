using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t1 = typeof(Marvellous);

            Console.WriteLine("Methods of {0} type..", t1);

            MethodInfo[] MI1 = t1.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            foreach (MethodInfo m in MI1)
            {
                Console.WriteLine(m);
            }
        }
    }

    public class Marvellous
    {
        public void fun()
        { }

        public void gun(int i)
        { }

        public void sun(char ch, int i)
        { }

        public void run(double d)
        { }
    }
}
