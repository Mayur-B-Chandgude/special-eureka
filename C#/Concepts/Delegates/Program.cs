using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int fptr(int No1,int No2);

delegate int mcast(int No1,int No2);

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Compare obj = new Compare();

            //crete single delegates
            fptr obj1 = new fptr(obj.Max);
            Console.WriteLine("Max number is:{0}", obj1(11, 21));

            fptr obj2 = new fptr(obj.Min);
            Console.WriteLine("Min number is:{0}", obj2(21, 11));

            //crete multicast delegates
            mcast del = new mcast(obj.Max);

            del += new mcast(obj.Min);

            Console.WriteLine("Min number is:{0}", del(51, 101));

            del -= new mcast(obj.Max);
            Console.WriteLine("Max mnumber is:{0}", del(151, 151));
        }
    }

    class Compare
    {
        public int Max(int No1, int No2)
        {
            if (No1 > No2)
            {
                return No1;
            }
            else
            {
                return No2;
            }
        }

        public int Min(int No1, int No2)
        {
            if (No1 < No2)
            {
                return No1;
            }
            else
            {
                return No2;
            }
        }
    }
}
