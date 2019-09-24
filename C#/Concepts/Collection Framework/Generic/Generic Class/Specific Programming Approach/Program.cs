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
            MarvellousInt IntObj = new MarvellousInt(10,20);
            int iret = IntObj.Add();
            Console.WriteLine("Addition is:{0}\n", iret);

            MarvellousFloat FloatObj = new MarvellousFloat(1.0f,2.0f);
            float fret = FloatObj.Add();
            Console.WriteLine("Addition is:{0}\n", fret);
        }
    }

    public class MarvellousInt
    {
        public int No1;
        public int No2;

        public MarvellousInt(int x, int y)
        {
            No1 = x;
            No2 = y;
        }

        public int Add()
        {
            return No1 + No2;
        }
    }

    public class MarvellousFloat
    {
        public float No1;
        public float No2;

        public MarvellousFloat(float x, float y)
        {
            No1 = x;
            No2 = y;
        }

        public float Add()
        {
            return No1 + No2;
        }
    }
}
