using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate int del(int No1, int No2);

namespace MarvellousArithmatic
{
    public class Class1
    {
        public int Add(int No1, int No2)
        {
            int result = 0;

            result = No1 + No2;
            return result;
        }

        public int Sub(int No1, int No2)
        {
            int result = 0;

            result = No1 - No2;
            return result;
        }

        public int Mul(int No1, int No2)
        {
            int result = 0;

            result = No1 * No2;
            return result;
        }

        public int Div(int No1, int No2)
        {
            if (No2 == 0)
            {
                return -1;
            }

            int result = 0;

            result = No1 / No2;
            return result;
        }
    }
}
