using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t1 = typeof(Marvellous);

            Console.WriteLine("Constructors of {0} type..", t1);

            ConstructorInfo[] CI1 = t1.GetConstructors(BindingFlags.Public | BindingFlags.Instance);

            foreach (ConstructorInfo c in CI1)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();

            Type t2 = typeof(string);

            Console.WriteLine("Constructors of {0} type..", t1);

            ConstructorInfo[] CI2 = t2.GetConstructors(BindingFlags.Public | BindingFlags.Instance);

            foreach (ConstructorInfo c in CI2)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();
        }
    }

    class Marvellous
    {
        public Marvellous()
        { }

        public Marvellous(int i)
        { }

        public Marvellous(int i, char ch)
        { }

        public Marvellous(Marvellous obj)
        { }

        ~Marvellous()
        { }
    }
}
