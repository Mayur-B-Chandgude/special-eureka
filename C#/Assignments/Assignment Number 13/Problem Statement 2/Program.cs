using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MarvellousConvertor;
using MarvellousString;

namespace Problem_Statement_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int value = Convert.ToInt32(Console.ReadLine());
            Class1 obj1 = new Class1(value);
            obj1.BinaryNumber();
            obj1.OctalNumber();
            obj1.HexaDecimal();

            Console.WriteLine("Enter String:");
            string name = Console.ReadLine();
            Class2 obj2 = new Class2(name);
            obj2.LargestWord();
            Console.WriteLine("Enter String for check palindrome:");
            string name1 = Console.ReadLine();
            Boolean bret = obj2.ChkPalindrome();
            if (bret == true)
            {
                Console.WriteLine("String is Palindrome..");
            }
            else
            {
                Console.WriteLine("String is not Palindrome..");
            }
        }
    }
}
