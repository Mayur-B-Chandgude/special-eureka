using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_and_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //Marvellous obj = new Marvellous();

            Marvellous obj1 = new Infosystem();

            obj1.fun();
            obj1.gun();
        }
    }

    abstract class Marvellous
    {
        public int i;

        public Marvellous()
        {
            Console.WriteLine("Inside Constructor of abstract Marvellous..");
            i = 11;
        }

        public abstract void fun();

        public void gun()
        {
            Console.WriteLine("Inside concrete gun of Marvellous..");
        }
    }

    class Infosystem : Marvellous
    {
        public override void fun()
        {
            Console.WriteLine("Inside concrete fun of Infosystem..");
        }
    }

    /*class NewInfosystem : Marvellous
    {
 
    }*/
}
