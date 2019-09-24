using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived1 dobj1 = new Derived1();
            dobj1.Display();

            Derived2 dobj2 = new Derived2();
            dobj2.fun();

            Derived3 dobj3 = new Derived3(11);
        }
    }

    public class Base1
    {
        public string name = "Marvellous";
    }

    public class Derived1 : Base1
    {
        public string name = "Infosystem";

        public void Display()
        {
            Console.WriteLine(base.name);
            Console.WriteLine(name);
        }
    }

    public class Base2
    {
        public void fun()
        {
            Console.WriteLine("Inside Base2 fun..");
        }
    }

    public class Derived2 : Base2
    {
        public void fun()
        {
            Console.WriteLine("Inside Derived2 fun..");
            base.fun();
        }
    }

    public class Base3
    {
        public Base3(int i)
        {
            Console.WriteLine("Inside Base3 Constructor..");
        }
    }

    public class Derived3 : Base3
    {
        public Derived3(int x) : base(x) 
        {
            Console.WriteLine("Inside Derived3 Constructor..");
        }
    }
}
