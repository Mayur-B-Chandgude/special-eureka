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
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt16(Console.ReadLine());

            Bitwise bobj = new Bitwise(num);

            int ret = bobj.CountOnBit();
            Console.WriteLine("Count of 1s:{0}", ret);

            Console.WriteLine("Binary Representation is-");
            bobj.DisplayBinary();
            
            Boolean bret = bobj.CheckBit(5);
            if (bret == true)
            {
                Console.WriteLine("Bit at 5 position is ON..");
            }
            else
            {
                Console.WriteLine("Bit at 5 position is OFF..");
            }

            bobj.OffBit(7);
            Console.WriteLine("Updated Number is:{0}", bobj.No);

            bobj.ToggleBit(6);
            Console.WriteLine("Updated Number is:{0}", bobj.No);
        }
    }

    abstract class MarvellousNumber
    {
        public int No;

        public MarvellousNumber(int value)
        {
            No = value;
        }

        public abstract int CountOnBit();
        public abstract void DisplayBinary();
        public abstract Boolean CheckBit(int pos);
        public abstract void OffBit(int pos);
        public abstract void ToggleBit(int pos);
    }

    class Bitwise : MarvellousNumber
    {
        public Bitwise(int value): base(value)
        {
 
        }

        public override int CountOnBit()
        {
            int cnt = 0;

            while (No != 0)
            {
                if((No % 2) == 0)
                {
                    cnt++;
                }
                No = No / 2;
            }

            return cnt;
        }

        public override void DisplayBinary()
        {
            var binary = Convert.ToString(No, 2);
            Console.WriteLine(binary);
        }

        public override void OffBit(int pos)
        {
            UInt32 imask = 1;
            UInt32 result = 0;

            if ((pos < 1) || (pos > 32))
            {
                return;
            }

            imask = imask << (pos - 1);
            imask = ~imask;
            result = (UInt32)No & imask;
        }

        public override Boolean CheckBit(int pos)
        {
            int bcnt = 1;
            int bdigit = 0;

            while ((bcnt <= pos) && (No != 0))
            {
                bdigit = No % 2;
                No = No / 2;
                bcnt++;
            }

            if (((No == 0) && (bcnt != pos + 1) || (bdigit == 0)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override void ToggleBit(int pos)
        {
            UInt32 imask = 1;
            UInt32 result = 0;

            imask = imask << (pos - 1); ;
            result = (UInt32)No ^ imask;
        }
    }
}
