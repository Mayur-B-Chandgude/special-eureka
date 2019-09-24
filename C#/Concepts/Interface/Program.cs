using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Marvellous obj = new Marvellous();

            Marvellous mobj1 = new Demo();
            mobj1.fun();

            Hello hobj = new Hello();
            hobj.fun();
            hobj.gun();
        }
    }

    interface Marvellous
    {
        void fun();

        /*public void gun()
        {
 
        }*/
    }

    interface Infosystem
    {
        void gun();
    }

    class Demo : Marvellous
    {
        public void fun()
        {
            Console.WriteLine("Inside concrete function fun:Demo");
        }
    }

    class Hello : Marvellous, Infosystem
    {
        public void fun()
        {
            Console.WriteLine("Inside concrete function fun:Hello");
        }

        public void gun()
        {
            Console.WriteLine("Inside concrete function gun:Hello");
        }
    }
}
