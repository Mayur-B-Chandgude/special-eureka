﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Statement_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();

            obj.fun();
        }
    }

    class Demo
    {
        public int No1, No2;

        public Demo()
        {
            Console.WriteLine("Enter First Number:");
            No1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            No2 = Convert.ToInt32(Console.ReadLine());
        }

        public void fun()
        {
            try
            {
                int ans = No1 / No2;
                Console.WriteLine("Hello");
            }

          // Console.WriteLine("hello");

          finally
            {
                Console.WriteLine("Inside Finally Block..");
            }

            Console.WriteLine("Rest of the code..");
        }
    }
}