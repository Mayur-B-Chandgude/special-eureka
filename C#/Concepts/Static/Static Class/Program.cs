using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo obj = new Demo();

            Demo.gun();
        }
    }

    static class Demo
    {
        //public int i;

        public static int j = 11;

        /*public void fun()
        {
            Console.WriteLine("Inside Non static fun..");
        }*/

        /*public Demo()
        {
            
        }*/

        public static void gun()
        {
        
        }
    }
}
