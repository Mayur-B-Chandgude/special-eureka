using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Statement_1
{
    class Program
    {
        static void Main(string[] args)
        {
            AgeInvalidException obj = new AgeInvalidException();
        }
    }

    public class AgeInvalidException : Exception
    {
        public AgeInvalidException()
        {
            Console.WriteLine("Inside Default Constructor..");
        }

        public AgeInvalidException(String message)
            : base(message)
        {
            Console.WriteLine("Inside Parameterized Constructor..");
        }

        public AgeInvalidException(string message, Exception inner)
            : base(message, inner)
        {
            Console.WriteLine("Inside Copy Constructor..");
        }
    }
}
