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
                Console.WriteLine("Enter Birth Date:");
                DateTime birthdate = DateTime.Parse(Console.ReadLine());

                if (DateTime.Today.Year < birthdate.Year)
                {
                    throw new InvalidAgeException("Invalid Age");
                }
                else
                {
                    //Console.WriteLine("Age is Valid..");

                    Marvellous mobj = new Marvellous();
                    mobj.Display(birthdate);
                }
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e);
            }
        }
    }

    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
           
        }
    }

    class Marvellous
    {
        public void Display(DateTime birthdate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthdate.Year;

            Console.WriteLine("Age is:{0}", age);
        }
    }
}
