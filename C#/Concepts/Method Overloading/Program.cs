using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Marvellous mobj = new Marvellous();

            Console.WriteLine("First call:{0}\n", mobj.Add(10, 20));
            Console.WriteLine("Second call:{0}\n", mobj.Add(10, 20, 30));

            Console.WriteLine("Third call:{0}\n", mobj.Sub(20, 10));
            Console.WriteLine("Fourth call:{0}\n", mobj.Sub(15.0f, 4.0f));

            Console.WriteLine("Fifth call:{0}\n", mobj.Addx(15, 4.8f));
            Console.WriteLine("Sixth call:{0}\n", mobj.Addx(10.2f, 5));
        }
    }

    class Marvellous
    {
        //////////////////////////////////////////////////////////////////
        public int Add(int No1, int No2)
        {
            return (No1 + No2);
        }

        public int Add(int No1, int No2, int No3)
        {
            return (No1 + No2 + No3);
        }
        //////////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////////
        public int Sub(int No1, int No2)
        {
            return (No1 - No2);
        }
        
        public float Sub(float No1, float No2)
        {
            return (No1 - No2);
        }
        //////////////////////////////////////////////////////////////////


        /////////////////////////////////////////////////////////////////
        public float Addx(int No1, float No2)
        {
            return (No1 + No2);
        }

        public float Addx(float No1, int No2)
        {
            return (No1 + No2);
        }
        /////////////////////////////////////////////////////////////////
    }
}
