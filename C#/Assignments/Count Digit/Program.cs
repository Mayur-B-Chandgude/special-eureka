using System;

namespace CommandLine_Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(args[0]);
            int num2 = int.Parse(args[1]);
            int num3 = int.Parse(args[2]);
            int num4 = int.Parse(args[3]);
            int num5 = int.Parse(args[4]);


            CommandLine obj = new CommandLine();

            int ret = obj.Add(num1 , num2 , num3 , num4 , num5);
            Console.WriteLine("Addition is:{0}", ret);
        }
    }

    class CommandLine
    {
        public int Add(int No1, int No2, int No3, int No4 , int No5)
        {
            int ret = No1 + No2 + No3 + No4 + No5;
            return ret;
        }
    }
}
