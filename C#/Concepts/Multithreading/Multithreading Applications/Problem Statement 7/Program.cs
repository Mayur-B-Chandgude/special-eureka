using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Problem_Statement_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            int value1 = Convert.ToInt32(Console.ReadLine());

            SingleTask2 tobj = new SingleTask2();

            Thread t14 = new Thread(new ParameterizedThreadStart(tobj.Display));

            Thread t15 = new Thread(new ParameterizedThreadStart(tobj.Display));

            t14.Name = "Marvellous Fourteen";

            t15.Name = "Marvellous Fiftheen";

            t14.Start(value1);

            t15.Start(value1);
        }
    }

    public class SingleTask2
    {
        public void Display(Object No1)
        {
            Thread t = Thread.CurrentThread;

            for (int i = 0; i < (int)No1; i++)
            {
                Console.WriteLine(t.Name + " is runnig ");

                Console.WriteLine(i);
            }
        }
    }
}