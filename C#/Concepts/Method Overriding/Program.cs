using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Base bobj = new Base();

            Derived dobj = new Derived();

            bobj.fun();
            bobj.gun();

            dobj.fun();
            dobj.gun();

            Base obj = new Derived();

            obj.fun();
            obj.gun();
        }
    }

    class Base
    {
        public void fun()
        {
            Console.WriteLine("Inside base fun..");
        }

        public virtual void gun()
        {
            Console.WriteLine("Inside base gun..");
        }
    }

    class Derived : Base
    {
        public void fun()
        {
            Console.WriteLine("Inside derived fun..");
        }

        public override void gun()
        {
            //base.gun();
            Console.WriteLine("Inside derived gun..");
        } 
    }
}
