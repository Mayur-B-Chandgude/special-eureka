using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessor_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            MarvellousBook b1 = new MarvellousBook();

            b1.Name = "Windows Internal";
            b1.Price = 900;
            Console.WriteLine("Book Info:{0}", b1);

            b1.Price += 100;
            Console.WriteLine("Book Info:{0}", b1);

            MarvellousBook b2 = new MarvellousBook();

            b2.Name = "Angular Web Development";
            b2.Price = 1000;
            Console.WriteLine("Book Info:{0}", b2);

            b2.Price -= 50;
            Console.WriteLine("Book Info:{0}", b2);
        }
    }

    class MarvellousBook
    {

        private string name = "not known";
        private int price = 0;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public override string ToString()
        {
            return "Book Name = " + Name + " ,  Price = " + Price; 
        }
    }
}
