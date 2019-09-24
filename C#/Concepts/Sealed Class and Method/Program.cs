using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_class_and_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo obj1 = new Demo();

            Marvellous mobj = new Marvellous();

            mobj.obj.fun();
        }
    }

    sealed class Demo
    {
        public void fun()
        {
            Console.WriteLine("Inside Demo fun..");
        }
    }

    /*class Hello : Demo
    {
 
    }*/

    class Marvellous
    {
        public int i;

        public Demo obj;

        public Marvellous()
        {
            i = 11;
            obj = new Demo();
        }
    }

    class Infosystem
    {
        public virtual void gun()
        {
            Console.WriteLine("Inside infosystem gun..");
        }

        public virtual void sun()
        {
            Console.WriteLine("Inside infosystem sun..");
        }
    }

    class Myclass : Infosystem
    {
        public override void gun()
        {
            Console.WriteLine("Inside myclass gun..");
        }

        public sealed override void sun()
        {
            //base.sun();
            Console.WriteLine("Inside myclass sun..");
        }
    }

    class Newclass : Myclass
    {
        public override void gun()
        {
            //base.gun();
            Console.WriteLine("Inside newclass gun..");
        }

        /*public sealed override void sun()
        {
            Console.WriteLine("Inside newclass sun..");
        }*/
    }
}
