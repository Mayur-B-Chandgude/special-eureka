using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MarvellousString
{
    public class Class2
    {
        public string str;

        public Class2(string s)
        {
            str = s;
        }

        public void LargestWord()
        {
            string[] StrArray = str.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int cnt = 0;
            foreach (String s in StrArray)
            {
                if (s.Length > cnt)
                {
                    word = s;
                    cnt = s.Length;
                }
            }
            Console.WriteLine(word);
        }

        public Boolean ChkPalindrome()
        {
            var reversed = new string(str.Reverse().ToArray());
           
           if (str == reversed)
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
