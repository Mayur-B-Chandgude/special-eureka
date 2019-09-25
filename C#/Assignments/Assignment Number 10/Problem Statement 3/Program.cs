using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Statement_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Joining Date:");
                DateTime joindate = DateTime.Parse(Console.ReadLine());

                if (DateTime.Today.Year < joindate.Year)
                {
                    throw new InvalidDateException("Invalid Date");
                }
                else
                {
                    Marvellous mobj = new Marvellous();
                    mobj.Display(joindate);
                }
            }
            catch (InvalidDateException e)
            {
                Console.WriteLine(e);
            }
        }
    }

    class InvalidDateException : Exception
    {
        public InvalidDateException(string message)
            : base(message)
        {

        }
    }

    class Marvellous
    {
        public void Display(DateTime joindate)
        {
            DateTime today = DateTime.Today;
            int year = today.Year - joindate.Year;

            if (year <= 1)
            {
                Console.WriteLine("Designation is : Associate Software Engineer");
            }
            else if ((year > 1) && (year <= 3))
            {
                Console.WriteLine("Designation is : Senior Software Engineer Level 1");
            }
            else if((year > 3) && (year <= 5))
            {
                Console.WriteLine("Designation is : Senior Software Engineer Level 2");
            }
        }
    }
}
