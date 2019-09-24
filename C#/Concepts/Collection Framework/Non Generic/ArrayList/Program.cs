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
            ArrayList al = new ArrayList();

            al.Add(11);
            al.Add(21);
            al.Add(51);
            al.Add(101);
            al.Add(151);
            al.Add(201);

            Console.WriteLine("Capacity:{0}", al.Capacity);
            Console.WriteLine("Count:{0}", al.Count);

            Console.WriteLine("\n Contents of ArrayList:");
            foreach (int i in al)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n ArrayList After Sorting");
            al.Sort();
            foreach (int i in al)
            {
                Console.WriteLine(i + " ");
            }

            al.Add(9.7);
            al.Add("Marvellous");
            al.Add('M');

            Console.WriteLine("\n Contents of ArrayList:");
            foreach (Object i in al)
            {
                Console.WriteLine(i + " ");
            }

            int j = (int)al[0];

            Console.WriteLine("\n Accessed Element is:{0}", j);

            Console.WriteLine("\n Traversal using for loop");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

         //   Console.WriteLine("\n Insert Element at Position:");
            al.Insert(9, 251);

           // Console.WriteLine("\n Remove Element by value:");
            al.Remove(251);

           // Console.WriteLine("\n Remove Element at Index:");
            al.RemoveAt(7);

            Console.WriteLine("\n Traverse for loop After update:");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
        }
    }
}
