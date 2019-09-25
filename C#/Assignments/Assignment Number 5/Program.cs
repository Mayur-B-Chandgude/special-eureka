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
            Console.WriteLine("Enter String:");
            string name = Console.ReadLine();

            MarvellousStrong mobj = new MarvellousStrong(name);

            Console.WriteLine("Enter Character:");
            char ch = (char)Console.Read();

            int lenret = mobj.strlenX();
            Console.WriteLine("String length is:{0}",lenret);

            int CapRet = mobj.CountCapital();
            Console.WriteLine("Capital letters Count is:{0}", CapRet);

            int Smallret = mobj.CountSmall();
            Console.WriteLine("Small letters Count is:{0}", Smallret); 

            int Spaceret = mobj.CountSpace();
            Console.WriteLine("Space Count is:{0}", Spaceret); 

            int Freqret = mobj.Fequency(ch);
            Console.WriteLine("Frequency of letter is:{0}", Freqret); 

            int Firstret = mobj.SearchFirst(ch);
            Console.WriteLine("Index is:{0}", Firstret);

            int Lastret = mobj.SearchLast(ch);
            Console.WriteLine("Index is:{0}", Lastret); 

            Boolean bret = mobj.ChkPalindrome();
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

    class MarvellousStrong
    {
        public string str;

        public MarvellousStrong(string name)
        {
            str = name;
        }

        public int strlenX()
        {
            int cnt = 0;

            while (str != null)
            {
                cnt++;
            }

            return cnt;
        }

        public int CountCapital()
        {
            int cnt = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char chvalue = str[i];

                if ((chvalue >= 'A') && (chvalue <= 'Z'))
                {
                    cnt++;
                }
            }

                return cnt;
        }

        public int CountSmall()
        {
            int cnt = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char chvalue = str[i];

                if ((chvalue >= 'a') && (chvalue <= 'z'))
                {
                    cnt++;
                }
            }

                return cnt;
        }

        public int Fequency(char ch)
        {
            int cnt = 0;

            for(int i = 0; i<str.Length; i++)
            {
                char chvalue = str[i];

                if(chvalue == ch)
                {
                    cnt++;
                }
            }

            return cnt;
        }

        public int CountVowels()
        {
            int cnt = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char chvalue = str[i];

                if((chvalue == 'A')|| (chvalue == 'a') ||
                  (chvalue == 'E') || (chvalue == 'e') ||
                  (chvalue == 'I') || (chvalue == 'i') ||
                  (chvalue == 'O') || (chvalue == 'o') ||
                  (chvalue == 'U') || (chvalue == 'u')) 
                {
                    cnt++;
                }
            }
                return cnt;
        }

        public int CountSpace()
        {
            int cnt = 0;

            while (str != null)
            {
                if (str == " ")
                {
                    cnt++;
                }
            }

            return cnt;
        }

        public int SearchFirst(char ch)
        {
            int cnt = 0;
            int i = 0;

            for (i = 0; i < str.Length; i++)
            {
                char chvalue = str[i];

                if (chvalue == ch)
                {
                    break;
                }
            }

            if (i == str.Length)
            {
                return -1;
            }
            else
            {
                return i + 1;
            }
        }

            public int SearchLast(char ch)
            {
                int cnt = 0;
                int i = 0;

                for(i = str.Length; i>0; i--)
                {
                    char chvalue = str[i];

                    if (chvalue == ch)
                    {
                        break;
                    }
                }

                if(i == str.Length)
                {
                    return -1;
                }
                else
                {
                    return i+1;
                }
            }

            public Boolean ChkPalindrome()
            {
                string CheckPalindrome = "";

                for (int i = str.Length - 1; i >= 0; i--)
                {
                    CheckPalindrome = CheckPalindrome + str[i];
                }

                if (CheckPalindrome == str)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
