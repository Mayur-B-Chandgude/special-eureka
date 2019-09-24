using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Statement_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Any Number:");
                int value = Convert.ToInt32(Console.ReadLine());

                Marvellous.Accept(value);
            }
            catch (InvalidNumberException e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Termination of Application..");
        }
    }

    public class InvalidNumberException : Exception
    {
        public InvalidNumberException(string message)
            : base(message)
        {
            Console.WriteLine("User Defined Exception{0}", message);
        }
    }

    class Marvellous
    {
        public static void Accept(int No)
        {
            if (No < 0)
            {
                throw new InvalidNumberException("Input Should be Positive..");
            }
        }
    }
}
