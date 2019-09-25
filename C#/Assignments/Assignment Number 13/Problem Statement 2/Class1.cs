using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvellousConvertor
{
    public class Class1
    {
        public int No;

        public Class1(int x)
        {
            No = x;
        }

        public void BinaryNumber()
        {
            string binary = Convert.ToString(No, 2);

            Console.WriteLine("Binary Number:" + binary);
        }

        public void OctalNumber()
        {
            string binary = Convert.ToString(No, 8);

            Console.WriteLine("Octal Number:" + binary);
        }

        public void HexaDecimal()
        {
            string binary = Convert.ToString(No, 16);

            Console.WriteLine("Hexadecimal Number:" + binary);

        }
    }
}
