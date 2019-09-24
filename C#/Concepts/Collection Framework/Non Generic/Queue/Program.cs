using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Statement_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue qobj = new Queue();

            qobj.Enqueue('A');
            qobj.Enqueue('B');
            qobj.Enqueue('C');
            qobj.Enqueue('D');

            Console.WriteLine("Curretnt Queue is:");
            foreach (char c in qobj)
            {
                Console.WriteLine(c + " ");
            }

            qobj.Enqueue('F');
            qobj.Enqueue('G');

            Console.WriteLine("Curretnt Queue is:");
            foreach (char c in qobj)
            {
                Console.WriteLine(c + " ");
            }

            Console.WriteLine("Remove values:");

            char ch = (char)qobj.Dequeue();
            Console.WriteLine("Removed value is:{0}", ch);

            ch = (char)qobj.Dequeue();
            Console.WriteLine("Removed valuw is:{0}", ch);
        }
    }
}
