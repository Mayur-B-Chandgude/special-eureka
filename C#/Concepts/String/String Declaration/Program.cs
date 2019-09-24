using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Declaration
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
            string str1;
            //Console.WriteLine(str1);

            string str2 = null;
            Console.WriteLine(str2);

            String str3 = "";
            Console.WriteLine(str3);

            string str4 = System.String.Empty;
            Console.WriteLine(str4);

            string str5 = "Marvellous Infosystem";
            Console.WriteLine(str5);

            string str6 = @"Marvellous Infosystem";
            Console.WriteLine(str6);

            System.String str7 = "Marvellous Infosystem";
            Console.WriteLine(str7);

            var str8 = "Marvellous Infosystem";
            Console.WriteLine(str8);

            const string str9 = "Marvellous Infosystem";
            Console.WriteLine(str9);

            char[] Arr = { 'm', 'a', 'y', 'u', 'r' };
            string str10 = new string(Arr);
            Console.WriteLine(str10);
        }
    }
}
