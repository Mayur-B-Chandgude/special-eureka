using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class_And_Methods_New
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use of GetType method
            
            Object ob1 = new Object();

            String s1 = "Marvellous Infosystem";

            Derived dobj = new Derived();

            Type type1 = ob1.GetType();
            Type type2 = s1.GetType();
            Type type3 = dobj.GetType();

            Console.WriteLine("Demostaration of GetType method..");

            //Object class Output
            Console.WriteLine("Information of Object class:");
            Console.WriteLine(type1.BaseType);
            Console.WriteLine(type1.Name);
            Console.WriteLine(type1.FullName);
            Console.WriteLine(type1.Namespace);

            //Strong class Output
            Console.WriteLine("Information of String class:");
            Console.WriteLine(type2.BaseType);
            Console.WriteLine(type2.Name);
            Console.WriteLine(type2.FullName);
            Console.WriteLine(type2.Namespace);

            //Derived class output
            Console.WriteLine("Information of Derived class:");
            Console.WriteLine(type3.BaseType);
            Console.WriteLine(type3.Name);
            Console.WriteLine(type3.FullName);
            Console.WriteLine(type3.Namespace);

            Console.WriteLine("Demonstartion of Equals and ReferenceRquals methods..");

            Base obj1 = new Base();
            Base obj2 = new Derived();
            Base obj3 = new Base();
            Base obj4 = obj1;

            Console.WriteLine(Object.Equals(obj1, obj4));
            Console.WriteLine(Object.ReferenceEquals(obj1, obj4));

            string str1 = "String";
            string str2 = "String";
            string str3 = "String New";

            Console.WriteLine("Comparison of 2 Objects..");
            Console.WriteLine(Object.ReferenceEquals(obj1, obj2));
            Console.WriteLine(Object.ReferenceEquals(obj2, obj2));
            Console.WriteLine(Object.ReferenceEquals(obj1, obj3));
            Console.WriteLine(Object.ReferenceEquals(str1, str2));
            Console.WriteLine(Object.ReferenceEquals(str1, str2));
            Console.WriteLine(Object.ReferenceEquals(str1, str3));

            Console.WriteLine("Demonstration of GetHashCode method..");
            Console.WriteLine(str1.GetHashCode());
            Console.WriteLine(str2.GetHashCode());
            Console.WriteLine(str3.GetHashCode());

            Console.WriteLine("Demonstration of toString method..");
            int salary = 1200000;
            float percentage = 89.50f;

            string str4 = salary.ToString();
            string str5 = percentage.ToString();

            Console.WriteLine(str4);
            Console.WriteLine(str5);
        }
    }

    class Base
    {
        public int i = 11;
    }

    class Derived : Base
    {
 
    }
}
