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
            MarvellousInt <int> IntObj = new MarvellousInt <int> (10, 20);
            int iret = IntObj.Add();
            Console.WriteLine("Addition is:{0}\n", iret);

            MarvellousInt <float> FloatObj = new MarvellousInt <float> (1.0f, 2.0f);
            float fret = FloatObj.Add();
            Console.WriteLine("Addition is:{0}\n", fret);
        }
    }

    public class MarvellousInt<T>
    {
        public T No1;
        public T No2;

        public MarvellousInt(T x, T y)
        {
            No1 = x;
            No2 = y;
        }

        public T Add()
        {
            dynamic a = No1;
            dynamic b = No2;

            return a + b;
        }
    }
}
