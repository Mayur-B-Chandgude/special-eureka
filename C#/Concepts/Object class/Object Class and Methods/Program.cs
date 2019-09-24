using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class_nad_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use Of GetType method
            object obj = new object();
            string str1 = "Marvellous Infosystem";
            Derived dobj = new Derived();

            Type type1 = obj.GetType();
            Type type2 = str1.GetType();
            Type type3 = dobj.GetType();

            Console.WriteLine("Demonstration of GetType method..");

            //Object Class Output
            Console.WriteLine("Information of object class:");
            Console.WriteLine(type1.BaseType);
            Console.WriteLine(type1.Name);
            Console.WriteLine(type1.Namespace);
            Console.WriteLine(type1.FullName);
            Console.WriteLine(type1.DeclaringType);
            Console.WriteLine(type1.CustomAttributes);
            Console.WriteLine(type1.Attributes);

            //string output
            Console.WriteLine("Information of string class:");
            Console.WriteLine(type2.BaseType);
            Console.WriteLine(type2.Name);
            Console.WriteLine(type2.FullName);
            Console.WriteLine(type2.Namespace);
            Console.WriteLine(type2.ReflectedType);
            Console.WriteLine(type2.StructLayoutAttribute);
            Console.WriteLine(type2.TypeHandle);
            Console.WriteLine(type2.TypeInitializer);

            //Derived Output
            Console.WriteLine("Information of Derived class:");
            Console.WriteLine(type3.BaseType);
            Console.WriteLine(type3.Name);
            Console.WriteLine(type3.Namespace);
            Console.WriteLine(type3.FullName);
            Console.WriteLine(type3.IsClass);

            //Demonstration of Equals and ReferenceEqulas method

            Base bobj1 = new Base();
            Base bobj2 = new Derived();
            Base bobj3 = new Base();

            string str2 = "String";
            string str3 = "String";
            string str4 = "New String";

            Console.WriteLine("Comparison of 2 Objects:");
            Console.WriteLine(Object.Equals(bobj1, bobj2));
            Console.WriteLine(Object.Equals(str2, str3));

            Console.WriteLine(Object.ReferenceEquals(bobj1, bobj2));
            Console.WriteLine(Object.ReferenceEquals(bobj2, bobj2));
            Console.WriteLine(Object.ReferenceEquals(bobj1, bobj3));
            Console.WriteLine(Object.ReferenceEquals(str2, str3));
            Console.WriteLine(Object.ReferenceEquals(str2, str4));

            Console.WriteLine(str2.GetHashCode());
            Console.WriteLine(str3.GetHashCode());
            Console.WriteLine(str4.GetHashCode());

            Console.WriteLine("Demonstration of toString method:");
            int salary = 12000000;
            float percentage = 89.20f;

            string str5 = salary.ToString();
            string str6 = percentage.ToString();

            Console.WriteLine(str5);
            Console.WriteLine(str6);
        }
    }

    class Base
    {
 
    }

    class Derived : Base
    {
 
    }
}
