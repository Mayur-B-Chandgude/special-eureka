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
            Stack st = new Stack();

            st.Push('E');
            st.Push('N');
            st.Push('U');
            st.Push('P');

            Console.WriteLine("Elements from Stack:");
            foreach (char c in st)
            {
                Console.WriteLine(c + " ");
            }

            st.Push('2');
            st.Push('1');

            Console.WriteLine("Peek Stack:{0}", st.Peek());

            Console.WriteLine("Pop Element from the Stack:{0}", st.Pop());

            Console.WriteLine("Elements from Stack:");
            foreach (char c in st)
            {
                Console.WriteLine(c + " ");
            }

            Console.WriteLine("Removing values from Stack");
            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine("Current Stack:");
            //Console.WriteLine("Elements from Stack:");
            foreach (char c in st)
            {
                Console.WriteLine(c + " ");
            }
        }
    }
}
