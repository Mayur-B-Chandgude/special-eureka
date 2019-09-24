using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Advanced
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
        public void fun()
        {
            string s1 = "Hello\today";
            string s2 = @"Hello\today";

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            string a = "Marvellous";
            string b = "Infosystem";
            string c = "Marvellous";

            b += a;

            Console.WriteLine(a == b);
            Console.WriteLine((object)a == (object)c);

            Console.WriteLine(s1.Length);
            Console.WriteLine(s2.Length);

            string firstname;
            string lastname;

            firstname = "Piyush";
            lastname = "Khairnar";

            Console.WriteLine(firstname.Clone());

            Console.WriteLine(firstname.CompareTo(lastname));

            Console.WriteLine(firstname.Contains("us"));

            Console.WriteLine(firstname.EndsWith("h"));

            Console.WriteLine(firstname.Equals(lastname));

            Console.WriteLine(firstname.GetHashCode());

            Console.WriteLine(firstname.GetType());

            Console.WriteLine(firstname.GetTypeCode());

            Console.WriteLine(firstname.IndexOf("s"));

            Console.WriteLine(firstname.ToLower());

            Console.WriteLine(firstname.ToUpper());

            Console.WriteLine(firstname.Insert(0, "Hello"));

            Console.WriteLine(firstname.IsNormalized());

            Console.WriteLine(firstname.Length);

            Console.WriteLine(firstname.Remove(5));

            Console.WriteLine(firstname.Replace('P', 'A'));

            Console.WriteLine(firstname.StartsWith("P"));

            Console.WriteLine(firstname.Substring(1, 4));

            Console.WriteLine(firstname.Trim());
        }
    }
}
