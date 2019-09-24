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
            Hashtable ht = new Hashtable();

            ht.Add("10", "PPA");
            ht.Add("11", "LB");
            ht.Add("12", "IPD");
            ht.Add("13", "LSP");
            ht.Add("14", "Angular");

            ICollection keys = ht.Keys;

            Console.WriteLine("Elements from Hash Table..");
            foreach (string s in keys)
            {
                Console.WriteLine(s + " ");
            }

            Console.WriteLine("Elements After Removal..");
            ht.Remove("11");
            foreach (string s in keys)
            {
                Console.WriteLine(s + " ");
            }
        }
    }
}
