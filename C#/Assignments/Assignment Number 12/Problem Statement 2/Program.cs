using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate T Del<T>(T No1, T No2);

namespace Problem_Statement_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Marvellous mobj = new Marvellous();

            Del<int> DelAdd = new Del<int>(mobj.AddI);
            Console.WriteLine("Integer Addition is:{0}\n", DelAdd(10, 20));

            Del<float> DelFloat = new Del<float>(mobj.AddF);
            Console.WriteLine("Float Addition is:{0}\n", DelFloat(10.0f, 20.0f));

            Del<double> DelDouble = new Del<double>(mobj.AddD);
            Console.WriteLine("Double Addition is:{0}\n", DelDouble(10.0, 20.0));


            Del<string> DelString = new Del<string>(mobj.AddS);
            Console.WriteLine("String Addition is:{0}\n", DelString("Hello","World"));
        }
    }

    public class Marvellous
    {
        public int AddI(int No1, int No2)
        {
            int result = No1 + No2;

            return result;
        }

        public float AddF(float No1, float No2)
        {
            float result = No1 + No2;

            return result;
        }

        public double AddD(double No1, double No2)
        {
            double result = No1 + No2;

            return result;
        }

        public string AddS(string str1, string str2)
        {
            string result = str1 + str2;

            return result;
        }
    }
}
