using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Explicit_Linking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside Application..");

            try
            {
                Assembly DLL = Assembly.LoadFile(@"E:\C Sharp\Demo Assingment Program\DLL\Explicit Linking\Library\Library\Marvellous.dll");
                Console.WriteLine("DLL File Loaded into memory");

                Type[] types = DLL.GetTypes();
                Console.WriteLine("DataTypes from DLL gets fetched..");

                foreach (Type typ in types)
                {
                    Console.WriteLine("DataTypes from DLL is" + typ);

                    object obj = Activator.CreateInstance(typ);
                    Console.WriteLine("Object gets created of class" + typ);

                    MethodInfo MI = typ.GetMethod("fun");
                    Console.WriteLine("Address of method fun gets fetced..");

                    MI.Invoke(obj, null);

                    Console.WriteLine("method call complete..");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
