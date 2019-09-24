using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Employee ID:");
            int eid = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Employee Name:");
            string ename = Console.ReadLine();

            Console.Write("Enter Employee Salary is:");
            int esal = Convert.ToInt16(Console.ReadLine());

            Employee eobj1 = new Employee(eid, ename, esal);
            Employee eobj2 = new Employee(eid, ename, esal);

            eobj1.Display();
            eobj2.Display();
        }
    }

    class Employee
    {
        public int Eid;
        public String Ename;
        public int Esalary;

        public Employee(int value, string name, int sal)
        {
            this.Eid = value;
            this.Ename = name;
            this.Esalary = sal;
        }

        public void DisplaySalary()
        {
            Console.WriteLine("Employee Salary is:{0}", this.Esalary);
        }

        public void Display()
        {
            Console.WriteLine("Employee ID is:{0}", this.Eid);
            Console.WriteLine("Employee Name is:{0}", this.Ename);
            this.DisplaySalary();
        }
    }
}
