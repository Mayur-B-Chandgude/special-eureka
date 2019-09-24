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
            SortedList sl = new SortedList();

            sl.Add("10", "PPA");
            sl.Add("11", "Angular");
            sl.Add("12", "LB");
            sl.Add("13", "IPD");
            sl.Add("14", "LSP");

            if (sl.ContainsValue("C#"))
            {
                Console.WriteLine("This batch already into List");
            }
            else
            {
                sl.Add("15", "C#");
            }

            ICollection keys = sl.Keys;

            Console.WriteLine("Keys:");
            foreach (String s in keys)
            {
                Console.WriteLine(sl[s]);
            }

            sl.Remove("15");

            Console.WriteLine("After Element Removal Sorted List:");
            foreach (String s in keys)
            {
                Console.WriteLine(sl[s]);
            }
        }
    }
}
