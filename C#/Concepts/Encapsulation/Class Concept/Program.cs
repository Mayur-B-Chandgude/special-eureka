using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Concept
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee eobj1 = new Employee();
            Employee eobj2 = new Employee();

            eobj1.Accept();
            eobj1.Display();
        }
    }

    class Employee
    {
        public int Eid;
        public string name;
        public int Esalary;

        public void Accept()
        {
            Console.Write("Enter Employee ID:");
            Eid = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Employee Name:");
            name = Console.ReadLine();

            Console.Write("Enter Employee Salary:");
            Esalary = Convert.ToInt16(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Employee Details As:");
            Console.WriteLine("Employee ID is:{0}", Eid);
            Console.WriteLine("Employee Name is:{0}", name);
            Console.WriteLine("Employee Salary is:{0}", Esalary);
        }
    }
}
