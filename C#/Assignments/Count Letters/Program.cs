using System;

namespace CountLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Count obj = new Count();

            obj.Ccount();
        }
    }

    class Count
    {
        public void Ccount()
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();

            int CapCnt = 0, SmallCnt = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    CapCnt++;
                }
                else if(char.IsLower(str[i]))
                {
                    SmallCnt++;
                }
            }

            Console.WriteLine("Upper:{0}", CapCnt);
            Console.WriteLine("Lower:{0}", SmallCnt);
        }
    }
}
