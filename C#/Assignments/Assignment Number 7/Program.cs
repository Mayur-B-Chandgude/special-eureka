using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_Statement_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MarvellousAuthentication mobj;

            Boolean bret;

            Console.WriteLine("Enter Password:");
            String str = Console.ReadLine();

            mobj = new MarvellousAuthentication(str);

            bret = mobj.ChkPassword();

            try
            {
                if (bret == false)
                {
                    throw new InvalidPasswordException("Invalid Password");    
                }
                else
                {
                    Console.WriteLine("Password is valid..");
                }
            }

            catch (InvalidPasswordException e)
            {
                Console.WriteLine(e);
            }
        }
    }

    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException(string message) : base(message)
        {
 
        }
    }

    public class MarvellousAuthentication 
    {
        public string password;

        public MarvellousAuthentication(string str)
        {
            password = str;
        }

        public Boolean ChkPassword()
        {
            int CapCnt = 0;
            int SmallCnt = 0;
            int DigitCnt = 0;
            int SymCnt = 0;

            for (int i = 0; i < password.Length; i++)
            {
                char ch = password[i];

                if ((password[i] >= 'A') && (password[i] <= 'Z'))
                {
                    CapCnt++;
                }

                else if ((password[i] >= 'a') && (password[i] <= 'z'))
                {
                    SmallCnt++;
                }

                else if ((password[i] >= '1') && (password[i] <= '9'))
                {
                    DigitCnt++;
                }
                else
                {
                    SymCnt++;
                }
            }

            if ((CapCnt <= 3) || (SmallCnt <= 2) || (DigitCnt <= 2) || (SymCnt >= 1))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
